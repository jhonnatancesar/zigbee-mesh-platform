# Avaliacao da plataforma fisica do sensor MVP

## Alternativas comparadas

| Area | Alternativas | Recomendacao tecnica (pendente de validacao) | Riscos |
| --- | --- | --- | --- |
| Plataforma | Seeed Studio XIAO ESP32-C6 (ja definida) | XIAO ESP32-C6 e a plataforma fisica de avaliacao; esta TASK nao reabre sua escolha. | Confirmar revisao e disponibilidade somente quando uma compra for autorizada. |
| Sensor | SHT40; SHT41; SHT45; BME280 | Sensirion SHT41 aprovada para continuidade da TASK-032: mesma precisao tipica do SHT40, melhor limite maximo de erro de umidade e caracteristicas equivalentes de consumo, tamanho, tensao e I2C. SHT40 permanece alternativa de menor custo; SHT45, alternativa de maior precisao. | Confirmar encapsulamento, biblioteca, disponibilidade e precisao de lote. |
| Alimentacao | USB regulado; LiPo 1S recarregavel de 3,7 V | USB regulado para desenvolvimento, programacao e bancada; LiPo 1S para ensaios de autonomia com a XIAO ESP32-C6. Quimica definitiva do hardware proprio permanece aberta. | Li-SOCl2, AA e outras quimicas serao reavaliadas com dados reais; Li-SOCl2 nao sera ligada diretamente na entrada de bateria recarregavel da XIAO. |
| SDK/toolchain | ESP-IDF; ESP Zigbee SDK | Toolchain oficial: ESP-IDF, ESP Zigbee SDK, CMake/Ninja e idf.py; VS Code com extensao oficial e opcional. Arduino-ESP32 apenas para experimentos isolados; PlatformIO e Zephyr fora do MVP. | Versoes compativeis e estaveis permanecem pendentes da fundacao de firmware e de atualizacao controlada. |

## Interfaces e HAL propostas

HAL aprovada: interfaces minimas de dominio `sensor`, `power`, `time`, `storage`, `diagnostics` e `board`. `board` mapeia exclusivamente pinos, perifericos e caracteristicas da XIAO ESP32-C6. I2C atende sensor; GPIO atende interrupcao/energia quando aplicavel; ADC atende telemetria de alimentacao. HAL nao inclui Zigbee: `zigbee_adapter` separado encapsula ESP Zigbee SDK e expoe somente capacidades necessarias, sem regras de negocio. Telemetria, OTA, contratos e dominio nao chamam ESP-IDF; somente HAL, board e adaptadores de infraestrutura conhecem APIs Espressif. Interfaces sao simulaveis em testes unitarios e HAL nao contem politica de bateria, Zigbee, OTA ou telemetria.

## Metas propostas para aprovacao

Requisito comum aprovado para continuidade da TASK-032: ambas as variantes devem suportar 48 horas sem sua fonte primaria suficiente (rede na Variante A; geracao solar na Variante B). Quando viavel, compartilham bateria/familia, capacidade, protecao, regulador, INA228, telemetria e logica de firmware. Diferem somente na entrada e recarga: AC/DC com power-path na Variante A; painel com controlador solar e power-path na Variante B.

Decisao aprovada para continuidade: bateria comum Li-ion 18650 protegida em arquitetura 1S. Capacidade e numero de celulas em paralelo permanecem pendentes, podendo resultar em 1S1P, 1S2P ou superior conforme INA228 e requisito de 48 horas. Carregador, protecao e power-path serao externos; a XIAO e carga do subsistema de energia, e seu carregador embarcado nao e a solucao principal para recuperacao de 18650 ou solar.

Configuracao de bancada aprovada: 1S1P para primeiros ensaios. 1S2P e candidata preferencial para instalacao rural, sem aprovacao; 1S3P ou superior exige justificativa por dados reais. Capacidade total e paralelismo definitivo sao pendentes de dados experimentais: INA228, reserva de 48 horas, perdas, envelhecimento, temperatura e recuperacao solar. Packs paralelos futuros exigem celulas compativeis, protecao adequada e arquitetura correta de carga/power-path.

| Ensaio | Meta proposta | Instrumentos/evidencia |
| --- | --- | --- |
| Temperatura | erro absoluto <= 0,5 C em pontos definidos | referencia calibrada, planilha bruta e condicoes |
| Umidade | erro absoluto <= 3 %RH em pontos definidos | referencia calibrada, planilha bruta e condicoes |
| Calibracao | registrar antes/depois e metodo por unidade/lote | referencia rastreavel e identificador de unidade |
| Consumo | Medir sono, leitura SHT41, radio Zigbee, transmissao, associacao e reconexao com INA228; multimetro apenas como conferencia auxiliar. | Modulo INA228 e resistor shunt devem ser escolhidos para a faixa de corrente e resolucao de baixo consumo; shunt/faixa permanecem pendentes do metodo de ensaio. |
| Autonomia | calculo a partir de perfil medido e capacidade nominal | perfil, capacidade, temperatura e limitacoes |
| Enlace | registrar RSSI/LQI, perdas e topologia em ambiente definido | coordenador, router quando aplicavel e log correlacionado |
| Ambiente | registrar temperatura/umidade, duracao e comportamento | sensor de referencia e registro de ensaio |

Essas metas nao sao decisao aprovada. A TASK-031 so pode usá-las apos validacao do usuario e ADRs aprovados.

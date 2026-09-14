# Especificacao do sensor temperatura/umidade e plataforma embarcada

## Escopo

O MVP contempla um end device Zigbee com medicao de temperatura e umidade sobre plataforma ESP32-C6 prevista pelo Playbook. Esta especificacao nao escolhe sensor, alimentacao, SDK, toolchain ou interfaces concretas; tais lacunas estao em RFC-005.

## Requisitos funcionais e de fronteira

| Area | Requisito verificavel |
| --- | --- |
| Medicao | Produzir temperatura, umidade, unidade, instante, qualidade e diagnostico conforme `CONTRACTS.md`. |
| Energia | Expor estado de alimentacao e diagnosticos de consumo; nao pressupor bateria, fonte ou autonomia sem decisao aprovada. |
| Zigbee | Operar como end device, com identidade e comissionamento rastreaveis e sem privilegio administrativo implicito. |
| HAL | Isolar leitura de sensor, alimentacao, radio, tempo e armazenamento local da logica do papel do dispositivo. |
| Falhas | Reportar leitura invalida, indisponibilidade, reinicio, alimentacao anomala e falha de enlace de forma rastreavel. |
| Seguranca | Nao versionar credenciais, chaves ou certificados; OTA futura deve obedecer requisitos da TASK-029. |

## Metodologia de validacao fisica para TASK-031

| Ensaio | Evidencia minima | Criterio de aprovacao |
| --- | --- | --- |
| Leitura e interfaces | Amostras, versao de artefato, configuracao e instrumento | Campos contratuais presentes e leituras repetiveis conforme limite aprovado. |
| Precisao e calibracao | Referencia rastreavel, pontos de teste, condicoes e desvio | Limites e metodo de calibracao definidos por decisao aprovada; desvios registrados. |
| Consumo e autonomia | Perfil de operacao, instrumento, alimentacao e amostras | Consumo e autonomia comparados a meta aprovada; sem meta, resultado e limitacao registrados. |
| Alcance e enlace | Topologia, distancia, ambiente, perdas e rota | Qualidade e estabilidade avaliadas contra criterio aprovado; falhas rastreaveis. |
| Condicoes ambientais | Temperatura/umidade do ambiente, duracao e comportamento | Sem falha nao diagnosticada; limites de operacao dependem de componente aprovado. |

Cada ensaio deve registrar identificador, data, responsavel, hardware/firmware ensaiado, instrumentos, configuracao, dados brutos, resultado, limitacoes e correlacao com falhas. A TASK-031 executara esses ensaios; esta TASK nao os executa.

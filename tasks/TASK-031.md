# TASK-031 — Validação da plataforma física do sensor MVP

## Objetivo

Executar a validação física da plataforma aprovada para o sensor de temperatura/umidade do MVP, conforme a metodologia definida pela TASK-003, sem desenvolver hardware proprietário.

## Contexto

O MVP inclui sensor proprietário, mas hardware proprietário é explicitamente excluído. É necessário eliminar essa ambiguidade e demonstrar que a plataforma selecionada atende aos requisitos documentados antes do firmware definitivo.

## Dependências

TASK-003 validada e decisão de plataforma registrada em ADR.

## Escopo

Executar os ensaios definidos pela TASK-003 para o conjunto físico aprovado, incluindo os critérios aplicáveis de interfaces, alimentação, leitura, precisão, calibração, consumo, autonomia, alcance, qualidade do enlace e condições ambientais. Usar os instrumentos, critérios de aprovação e formato de evidência definidos na TASK-003. Registrar resultados e limitações; não redefinir a metodologia. Não projetar PCB, fabricar hardware ou realizar compras fora da autorização específica.

## Arquivos permitidos

`hardware/`, `docs/`, `adr/`, `tasks/TASK-031.md`, `CHANGELOG.md`.

## Arquivos proibidos

PCB, esquemáticos de produção, fabricação, compras não autorizadas, firmware de produto, `server/`, OTA e IA.

## Critérios de aceite

- A interpretação de “sensor proprietário” é compatível com a exclusão de hardware proprietário do MVP.
- Alimentação, interfaces, precisão, calibração, consumo, autonomia, alcance e qualidade do enlace atendem aos critérios aplicáveis definidos pela TASK-003 ou possuem limitações registradas.
- Evidências de validação física são registradas no formato definido pela TASK-003 e são rastreáveis.

## Testes obrigatórios

Executar os ensaios de leitura, precisão/calibração, consumo, autonomia, alimentação, alcance, qualidade do enlace e condições ambientais definidos como aplicáveis pela TASK-003, com os instrumentos e critérios nela especificados.

## Resultado esperado

Resultados de validação física comparados aos critérios previamente definidos, com aprovação ou bloqueios objetivos registrados antes do firmware do end device.

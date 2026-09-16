# ADR-005 - Modelo de capacidades Zigbee anunciadas

## Status

Aprovado.

## Contexto

O MVP deve interoperar com dispositivos Zigbee de terceiros sem lista fixa de marcas ou modelos. TASK-033 validou descoberta por padrões e representação baseada nas capacidades efetivamente anunciadas.

## Decisão

- Descobrir dispositivos por BDB, ZDO e ZCL, registrando identidade IEEE, fabricante/modelo quando disponíveis, endpoints, clusters de entrada/saída, atributos, reports/eventos e comandos suportados.
- Persistir resultados de descoberta, tentativas, instantes, falhas seguras e evidências que fundamentam cada capacidade derivada.
- Expor capacidades somente quando houver evidência de endpoint, cluster, direção, atributo ou comando suportado; fabricante/modelo nunca é condição suficiente.
- Dispositivos parcialmente reconhecidos permanecem seguros, observáveis e utilizáveis apenas nas capacidades comprovadas.
- Clusters desconhecidos ou proprietários são preservados como capacidades opacas, sem parser, escrita ou comando implícito.
- Leitura, escrita, reports e comandos usam somente elementos anunciados e compatíveis com tipo, direção, acesso e autorização.
- API e integração futura Home Assistant devem consumir o catálogo local de capacidades e estados, sem acesso direto ao rádio nem lista fixa de modelos.

## Consequências

- Uma lâmpada comercial que anuncie On/Off pode entrar, ter seu estado consultado e receber somente On/Off, sem integração específica de fabricante.
- Ausência de cluster, atributo ou resposta reduz a capacidade exposta, mas não quebra a rede nem remove o dispositivo automaticamente.
- TASK-019 continua responsável por demonstrar formalmente interoperabilidade comercial com matriz de testes.

## Alternativas consideradas

- Catálogo fixo por fabricante/modelo: rejeitado por limitar interoperabilidade e exigir manutenção específica por produto.
- Inferir comandos de capacidades parecidas: rejeitado por poder enviar ações não suportadas ou inseguras.
- Descartar clusters proprietários: rejeitado porque remove diagnóstico e possibilidade de suporte futuro.

## Rastreabilidade

TASK-033; RFC-007; `docs/COORDINATOR_INTEROPERABILITY_ARCHITECTURE.md`; `docs/CONTRACTS.md`; TASK-007; TASK-013; TASK-019.

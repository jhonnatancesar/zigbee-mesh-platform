# Roadmap do produto

TASK-032 está **SUSPENSA POR REPRIORIZAÇÃO — NÃO BLOQUEANTE**. As análises acumuladas permanecem preservadas para retomada futura. TASK-033 e TASK-034 estão concluídas; ADRs do coordenador precedem a implementação prioritária do coordenador.

O foco prioritario do MVP e coordenador e rede Zigbee interoperavel. O sensor proprio e caso de referencia/teste; sua validacao fisica nao bloqueia a cadeia do coordenador.

TASK-034 definiu a plataforma do servidor e ADR-001/ADR-002 liberam TASK-008. TASK-033 definiu a base do coordenador e interoperabilidade; TASK-007 consome a fundacao do servidor e os ADRs do coordenador. TASK-019 executa os testes formais com dispositivos comerciais.

## MVP

O MVP inclui coordenador Zigbee, routers, end devices, sensor proprietario de temperatura/umidade, servidor local, banco proprio, APIs administrativas, Home Assistant como cliente, IA, OTA e seguranca com TLS/tokens.

O MVP exclui LoRa, hardware proprio, interface propria e nuvem comercial.

As TASKs `001` a `020`, apoiadas pelas TASKs `029` a `031`, descrevem a sequencia proposta de arquitetura, requisitos, componentes, integracoes e validacao do MVP. A ordem executavel e determinada pelas dependencias declaradas em cada TASK e pelo indice do backlog, nao apenas pelo numero.

## V2

A V2 preve LoRa, hardware proprietario, protocolo proprio, coordenador movel e acesso remoto. Esses itens estao representados pelas TASKs `021` a `025` apenas como planejamento sujeito a autorizacao especifica.

## Visao futura

IA distribuida, multi-servidor e marketplace de dispositivos pertencem ao horizonte futuro. As TASKs `026` a `028` sao propostas documentais; nao autorizam implementacao.

Novas ideias para versões futuras não alteram este roadmap automaticamente: devem passar pela triagem em `IDEA_TRIAGE.md` e, quando aprovadas para planejamento, ser registradas em `FUTURE_BACKLOG.md`.

## Marco atual

TASK-034 foi validada e ADR-001/ADR-002 foram aprovados. TASK-008 e a proxima TASK valida; ela nao escolhe o banco definitivo da TASK-009.

TASK-032 precede a aprovacao das decisoes, ADRs, TASK-031, TASK-004 e TASK-005. Ela corrige a lacuna de decisao da plataforma fisica sem autorizar compra, ensaio ou implementacao.

TASK-000 e TASK-001 foram validadas. Nenhum marco posterior foi iniciado ou validado.

TASK-029 foi validada e estabeleceu a arquitetura documental de seguranca do MVP. Nenhum componente posterior foi iniciado ou validado.

TASK-002 foi validada e estabeleceu os contratos documentais de eventos, dados e API administrativa. Nenhum componente posterior foi iniciado ou validado.

TASK-003 foi validada e estabeleceu os requisitos documentais do sensor e a metodologia para validacao fisica futura.

A TASK-000 estruturou a documentacao e o backlog. Nenhum marco posterior foi iniciado ou validado.

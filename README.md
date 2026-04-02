# 🧊 First Game: Core Gameplay Loop

Bem-vindo ao repositório do meu primeiro projeto completo na Unity! 

Este projeto foi desenvolvido como um estudo prático para aplicar conceitos de lógica de programação, estruturação de dados e arquitetura de software diretamente no desenvolvimento de jogos com C#. O foco principal foi sair da teoria e construir um **Core Gameplay Loop** (Ciclo Principal de Jogo) 100% funcional.

## 🎯 O Que o Projeto Faz
O jogador controla um cubo 3D que deve se movimentar por uma arena para coletar moedas geradas dinamicamente. Ao atingir a pontuação alvo, o jogo detecta a vitória, exibe o feedback visual na interface e permite que o ciclo seja reiniciado.

## 🛠️ Tecnologias e Arquitetura Aplicadas

Durante o desenvolvimento deste protótipo, fiz a transição de conceitos lógicos (como os vistos no Python) para o ambiente fortemente tipado do C#, implementando os seguintes sistemas:

* **Física e Movimentação Independente de Quadros:** Uso de vetores (X, Y, Z) multiplicados por `Time.deltaTime` para garantir que a movimentação do jogador seja fluida e consistente, independentemente do FPS da máquina.
* **Geração Procedural (Spawner):** Criação de um sistema com laços de repetição (`for`) e leitura de limites espaciais (`MeshRenderer.bounds`) para instanciar *Prefabs* de moedas em posições aleatórias e seguras do mapa.
* **Banco de Dados Nativo (ScriptableObjects):** Em vez de "chumbar" valores no código (Hardcoding), criei uma arquitetura de dados usando `ScriptableObjects` (`DadosDaMoeda`). Isso permite criar diferentes tipos de itens visuais na Unity (com nomes e valores distintos) sem alterar nenhuma linha de código.
* **Programação Orientada a Eventos (Event-Driven):** Otimização de processamento. A verificação de vitória e atualização da UI não rodam a cada frame no `Update()`. Elas são disparadas apenas no exato milissegundo em que ocorre a colisão (`OnTriggerEnter` + `GetComponent`), economizando recursos.
* **Game Feel (Juice):** Implementação de feedback audiovisual instantâneo com `AudioSource` (tocando clipes de som via `PlayOneShot`) e `Particle System` instanciado dinamicamente na posição exata da coleta.
* **Gerenciamento de Estado (Game Manager):** Separação de responsabilidades. Um script dedicado exclusivamente a gerenciar o estado da partida e recarregar a cena usando a biblioteca `UnityEngine.SceneManagement`.
  
## 🔊 Créditos e Atribuições
* **Efeitos Sonoros:** O efeito de som da coleta de moedas foi gerado utilizando inteligência artificial através da plataforma [ElevenLabs](https://elevenlabs.io/).
  
## 🚀 Próximos Passos
Esta base arquitetônica está pronta para ser expandida. Os próximos estudos focarão em **Interação Avançada e Mobile**, incluindo:
- Controles virtuais (Touch/Joysticks).
- Interação por visão (`Raycast`).
- Máquinas de Estado (State Machines) para controle de comportamento complexo.

---
*Este projeto marca a conclusão do meu Nível 2 de estudos em Sistemas e Arquitetura na engine Unity.*
```

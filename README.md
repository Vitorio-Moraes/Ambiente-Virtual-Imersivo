# Ambiente-Virtual-Imersivo
Projeto realizado em Unity, para criação de um ambiente virtual imersivo utilizando a API Openx XR, para criação de um jogo de "Hoops" e Ping-Pong. 
🏓 VR Sports Interaction Demo

Este projeto é um ambiente imersivo 3D desenvolvido em Unity para a disciplina de Computação Gráfica. O objetivo foi criar uma experiência de Realidade Virtual (VR) onde o usuário pode navegar e interagir com objetos esportivos utilizando física realista.
📝 Sobre o Projeto

O cenário simula uma área de lazer contendo uma mesa de tênis de mesa e uma tabela de basquete. O foco principal não é a simulação esportiva profissional, mas sim a implementação técnica de interações de "pegar e arremessar" (Grab & Throw) e o comportamento físico de diferentes materiais em VR.
Funcionalidades Principais

    Navegação: Movimentação contínua (Continuous Locomotion) utilizando os analógicos, permitindo exploração livre do cenário.

    Interação Física: Uso do XR Interaction Toolkit para pegar, segurar e arremessar objetos.

    Física de Materiais: Configuração de Physic Materials distintos para simular o "quique" da bola de basquete (borracha) vs. bola de ping-pong (plástico rígido).

    Colisão de Alta Precisão: Implementação de Continuous Dynamic Collision e Velocity Tracking para garantir que a raquete não atravesse a bolinha em movimentos rápidos.

    Sistema de Reset: Interface de usuário (World Space UI) com script personalizado para reposicionar as bolas caso caiam longe.

🎮 Controles (Meta Quest)
Ação	Botão / Gatilho
Pegar Objeto	Grip Button (Gatilho Lateral)
Teletransporte	Trigger / Stick (Dependendo da config do controle)
Interagir com UI	Trigger (Gatilho Frontal - Ray Interactor)
Resetar Bolas	Botão virtual "Resetar" no painel flutuante
🛠️ Tecnologias e Implementação

    Engine: Unity 2022/2023 (VR Template)

    Framework: OpenXR & XR Interaction Toolkit

    Linguagem: Chttps://www.google.com/search?q=%23

    Destaques Técnicos:

        Script ResetBolas.cs: Gerencia o estado dos objetos Rigidbody, zerando a velocidade angular e linear antes de teleportá-los para os spawn points.

        Mesh Colliders: Ajuste de malhas Convex e Non-Convex para garantir que a bola de basquete passe corretamente por dentro do aro.

🚀 Como Executar

    Baixe o arquivo .apk disponível na aba Releases.

    Conecte o headset (Meta Quest 2/3) ao PC via USB.

    Utilize o SideQuest ou Meta Quest Developer Hub para instalar o APK.

    Execute o aplicativo através da biblioteca "Unknown Sources" no headset.

👥 Autores

    Vitório Moraes

    Jamile Hassen

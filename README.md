# MiniRouteOptimizer

Este projeto é a solução para a Atividade Prática 02 da disciplina de Códigos de Alta Performance. O objetivo principal do sistema é representar uma cidade fictícia em formato de grafo e calcular rotas otimizadas entre diferentes pontos.

## 🧠 Explicação Conceitual

A solução foi desenvolvida aplicando os seguintes conceitos algorítmicos:
- **Grafos:** A cidade é representada por um grafo direcionado, onde os vértices são os pontos (locais) e as arestas são as conexões com seus respectivos custos. A estrutura utiliza uma Lista de Adjacência para otimizar a consulta de vizinhos.
- **Algoritmo de Caminho Mínimo (Dijkstra):** Utilizado para encontrar a rota de menor custo total entre a origem e o destino.
- **Fila de Prioridade (Priority Queue):** Essencial para a alta performance do algoritmo de Dijkstra, permitindo extrair sempre o nó com o menor custo acumulado de forma eficiente.
- **Ordenação e Desempate (Heap/IComparable):** As rotas são ordenadas primariamente pelo menor custo total. Como critério de desempate, implementou-se a priorização de caminhos que exigem menos paradas.

## 🚀 Como Executar e Validar

Este projeto não possui interface gráfica ou dependência de banco de dados, sendo focado inteiramente na lógica de alta performance. 

Para validar o funcionamento da aplicação, certifique-se de ter o **.NET 8 SDK** instalado em sua máquina e siga os passos abaixo:

1. Abra o terminal na pasta raiz do projeto.
2. Execute o comando de testes automatizados:
   ```bash
   dotnet test

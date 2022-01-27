# Dio Series Web Mvc
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/henriquebenjamim/DioSeriesWebMvc/blob/main/LICENSE) 

# Sobre o projeto

Dio Series Web Mvc é um app que serve para gerenciamento de uma rede de academia, podendo adicionar departamentos da academia, alunos novos e filtar os treinos realizados.
Se trata de uma versão melhorada do projeto Dio Series que foi construído no bootcamp Decola Tech 2ª edição.

Este projeto foi construído através do material do curso "C# Completo" do Nelio Alves, a versão apresentada é para gerenciamento de lojas com departamentos e salários e vendas,
adaptei com o que gosto, academia e treino além de também fazer uma versão melhorada de um projeto feito anteriormente.

Caso tenha interesse em adquirir o curso: [Link do Curso](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/ "C# Completo OO")
- Dica: Eventualmente a udemy tem alguns cursos num valor bem em conta, este curso é um dos e você pode aproveitar esses momentos. 


## Layout web 

- Gym Departmens - Index
![Gym Departmens - Index](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/GymDepartmentsIndex.PNG)

- Gymmings
![Gymmings](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/Gymmings.PNG)

- Gymmings Delete
![GymmingsDelete](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/GymmingsDelete.PNG)

- Gymmings Details
![GymmingsDetails](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/GymmingsDetails.PNG)

- Gymmings Edit
![GymmingsEdit](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/GymmingsEdit.PNG)

- Workouts
![Workouts](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/Workouts.PNG)

- Grouping Search
![WorkoutGroupingSearch](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/WorkoutGroupingSearch.PNG)

- Simple Search
![WorkoutSimpleSearch](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/WorkoutSimpleSearch.PNG)


## Modelo conceitual
![Modelo Conceitual](https://github.com/henriquebenjamim/assets/blob/main/DioSeriesWebMvc/UMLDioSeriesWebMvc.png)

# Tecnologias utilizadas
## Back end
- DotNet 2.1
- MySql
- Entity Framework

## Front end
- Asp net Core
- Bootstrap

# Como executar o projeto
  
## Pré-requisitos
- DotNet 2.1
- AspNet 
- Entity Framework
- Visual studio 2019
- MySql (Importante, na instalação do MySql, utilize a opção de desenvolvedor e quando puder criar um novo usuário, crie um com as especificações:
Connection name: dev; UserName: developer; Password: 1234567;
- MySqlWorkbench;

```bash
# clonar repositório
git clone https://github.com/henriquebenjamim/DioSeriesWebMvc

# Checar se o serviço mysql está funcionando
Para poder visualizar isso realize estes passos:
- Abrir o painel de controle do computador;
- Na barra de pesquisa, digite: Ferramentas administrativas (Clique);
- Abra a aba "Serviços";
- Com a aba "Serviços" aberta, procure por "MySQL" e ative o serviço, caso não esteja ligado;
- Acesse o banco pelo "developer" com a senha pré definida (1234567);
- Agora Abra o Visual Studio através do caminho da pasta do projeto;
- Utilize o atalho "CTRL + F5" ou então inicie pelo "Play" do IIExpress;
- Agora poderás observar o projeto;

# Nota de problema
 - Na etapa de edição, deleção e detalhes do (Gymming), os redirecionamentos não estão funcionando (Dá uma tela de erro)
 - Porém, manualmente funciona (Ex: se digitar /Edit/IdDaPessoa)
 - Irei corrigir este problema

# Autor

Henrique Benjamim

[Veja o perfil do Henrique no Linkedin](https://www.linkedin.com/in/henriquebenjamim "Clique aqui")

[Atalho para voltar ao perfil do Github](https://github.com/henriquebenjamim "Clique aqui")

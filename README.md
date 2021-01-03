# Projeto - Exchange de Criptmoedas - WEB/Desktop :desktop_computer:


**:man_student: Dev: Daví Evangelista Silva**

**:school: Organização:** Universidade Paulista

**Observação:** Projeto feito como trabalho de conclusão de curso no ensino superior em Análise e Desenvolvimento de Sistemas. Neste repositório só estão inclusas as versões Web e Desktop, tendo em vista de que essas foram as quais eu tive total reponsabilidade, a versão mobile da qual também tive participação pode ser encontrada [aqui.](https://github.com/DaviESilva/PIM4_Mobile)

# **Descrição:** 
O projeto envolve a criação de uma plataforma de compra e venda de criptomoedas com utilização de uma versão Web, Desktop e Mobile. 
[Home](https://i.ibb.co/4Rbs3RJ/home.png)

A plataforma contém um sistema de login na platorma utilizando contas para armazenar suas informações de compra e venda de critoativos.
[cadastro](https://i.ibb.co/G0pGCtT/cadastro.png)

É possível realizar a compra e venda de criptomoedas uma vez que cadastrado na plataforma.
[moedas](https://i.ibb.co/ymCt532/moedas.png)

[contact](https://i.ibb.co/ckjdGp4/contato.png)

A versão desktop é para utilização de operadores da plataforma, para resolução de possíveis problemas.
[desktop](https://www.imagemhost.com.br/images/2021/01/03/desktop.png)

# Banco de dados
Para o total funcionamento do projeto, é necessario a criação do banco de dados.
Todas as soluções da plataforma utilizam o mesmo banco de dados, tendo assim uma integração.

O nome do banco deve ser: PIM4DB

E é somente necessária uma tabela chamada: User

O código para criação da tabela é:

CREATE TABLE [dbo].[User] (
    [IdUser]    INT             IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (15)   NOT NULL,
    [Email]     NVARCHAR (30)   NOT NULL,
    [Password]  NVARCHAR (20)   NOT NULL,
    [Birthday]  NVARCHAR (10)   NOT NULL,
    [Document]  NVARCHAR (20)   NOT NULL,
    [btcValue]  NUMERIC (16, 8) NOT NULL,
    [ethValue]  NUMERIC (16, 8) NOT NULL,
    [dogeValue] NUMERIC (16, 8) NOT NULL,
    [usdtValue] NUMERIC (16, 8) NOT NULL,
    [xrpValue]  NUMERIC (16, 8) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([IdUser] ASC)
);
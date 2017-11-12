USE [prova2]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/11/2017 18:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[idCustomer] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[telefone] [varchar](20) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[idCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 12/11/2017 18:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto](
	[idGasto] [int] IDENTITY(1,1) NOT NULL,
	[valor] [float] NOT NULL,
	[idMaterial] [int] NOT NULL,
 CONSTRAINT [PK_Gastos] PRIMARY KEY CLUSTERED 
(
	[idGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 12/11/2017 18:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[qtd] [int] NOT NULL,
 CONSTRAINT [PK_material] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 12/11/2017 18:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[idServico] [int] IDENTITY(1,1) NOT NULL,
	[tipoServico] [int] NOT NULL,
	[placaVeiculo] [varchar](50) NOT NULL,
	[preco] [float] NOT NULL,
	[idCliente] [int] NOT NULL,
	[tipoVeiculo] [int] NOT NULL,
 CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED 
(
	[idServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuario] (
    [idusuario]      INT           IDENTITY (1, 1) NOT NULL,
    [iddepartamento] INT           NOT NULL,
    [nome]           VARCHAR (50)  NOT NULL,
    [nomeusuario]    VARCHAR (20)  NOT NULL,
    [senha]          VARCHAR (128) NOT NULL,
    [cpfusuario]     INT           NOT NULL,
    [telefone]       INT           NOT NULL,
    [email]          VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([idusuario] ASC), 
    CONSTRAINT [iddepartamento] FOREIGN KEY ([iddepartamento]) REFERENCES [Departamento]([iddepartamento])
);


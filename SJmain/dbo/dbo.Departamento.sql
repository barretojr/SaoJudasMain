CREATE TABLE [dbo].[Departamento] (
    [iddepartamento]   INT          NOT NULL,
    [nomedepartamento] VARCHAR (15) NOT NULL,
    UNIQUE NONCLUSTERED ([iddepartamento] ASC)
);


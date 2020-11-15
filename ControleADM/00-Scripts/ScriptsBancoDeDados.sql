-- Table: public."Endereco"

-- DROP TABLE public."Endereco";

CREATE TABLE public."Endereco"
(
    "Id" integer NOT NULL,
    "Logradouro" character varying(256) COLLATE pg_catalog."default",
    "Numero" integer,
    "CEP" integer,
    "Bairro" character varying(50) COLLATE pg_catalog."default",
    "Cidade" character varying(30) COLLATE pg_catalog."default",
    "Estado" character varying(20) COLLATE pg_catalog."default",
    CONSTRAINT "Endereco_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Endereco"
    OWNER to postgres;





-- Table: public."Pessoa"

-- DROP TABLE public."Pessoa";

CREATE TABLE public."Pessoa"
(
    "CPF" bigint[],
    "Id" integer NOT NULL,
    "Nome" character varying(256) COLLATE pg_catalog."default",
    "Endereco" integer,
    CONSTRAINT "Pessoa_pkey" PRIMARY KEY ("Id"),
    CONSTRAINT "Pessoa_Endereco_fk" FOREIGN KEY ("Endereco")
        REFERENCES public."Endereco" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Pessoa"
    OWNER to postgres;

-- Index: fki_Pessoa_endereco_fk

-- DROP INDEX public."fki_Pessoa_endereco_fk";

CREATE INDEX "fki_Pessoa_endereco_fk"
    ON public."Pessoa" USING btree
    ("Endereco")
    TABLESPACE pg_default;













-- Table: public."Pessoa_telefone"

-- DROP TABLE public."Pessoa_telefone";

CREATE TABLE public."Pessoa_telefone"
(
    "Id_pessoa" integer NOT NULL,
    "Id_telefone" integer NOT NULL,
    CONSTRAINT "Pessoa_telefone_pkey" PRIMARY KEY ("Id_pessoa", "Id_telefone"),
    CONSTRAINT "Pessoa_Telefone_fk" FOREIGN KEY ("Id_pessoa")
        REFERENCES public."Pessoa" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT "Pessoa_telefone_telefone_fk" FOREIGN KEY ("Id_telefone")
        REFERENCES public."Telefone" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Pessoa_telefone"
    OWNER to postgres;

-- Index: fki_Pessoa_Telefone_fk

-- DROP INDEX public."fki_Pessoa_Telefone_fk";

CREATE INDEX "fki_Pessoa_Telefone_fk"
    ON public."Pessoa_telefone" USING btree
    ("Id_pessoa")
    TABLESPACE pg_default;

-- Index: fki_Pessoa_telefone_telefone_fk

-- DROP INDEX public."fki_Pessoa_telefone_telefone_fk";

CREATE INDEX "fki_Pessoa_telefone_telefone_fk"
    ON public."Pessoa_telefone" USING btree
    ("Id_telefone")
    TABLESPACE pg_default;

















-- Table: public."Telefone"

-- DROP TABLE public."Telefone";

CREATE TABLE public."Telefone"
(
    "Id" integer NOT NULL,
    "Numero" integer,
    "DDD" integer,
    "Tipo" integer,
    CONSTRAINT "Telefone_pkey" PRIMARY KEY ("Id"),
    CONSTRAINT "Telefone_Telefone_tipo" FOREIGN KEY ("Tipo")
        REFERENCES public."Telefone_Tipo" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Telefone"
    OWNER to postgres;

-- Index: fki_Telefone_Telefone_tipo

-- DROP INDEX public."fki_Telefone_Telefone_tipo";

CREATE INDEX "fki_Telefone_Telefone_tipo"
    ON public."Telefone" USING btree
    ("Tipo")
    TABLESPACE pg_default;



















-- Table: public."Telefone_Tipo"

-- DROP TABLE public."Telefone_Tipo";

CREATE TABLE public."Telefone_Tipo"
(
    "Id" integer NOT NULL,
    "Tipo" character varying(10) COLLATE pg_catalog."default",
    CONSTRAINT "Telefone_Tipo_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Telefone_Tipo"
    OWNER to postgres;













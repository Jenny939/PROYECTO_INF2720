%{
int yystopparser=0;
%}

%token VOID MAIN VARIABLE ENTERO DECIMAL BOLEANO CADENA T_ENTERO T_DECIMAL T_BOLEANO T_CADENA SUMA RESTA MULTIPLICACION DIVISION AUMENTAR DISMINUIR ASIGNADOR MAYOR MENOR IGUAL MAYORIGUAL MENORIGUAL NOIGUAL SI NO SINO PARA MIENTRAS

%start programa

%%

programa		: principal funciones | principal;

principal		: VOID MAIN '(' VOID ')' '{' lineascodigos '}';

lineascodigos		: lineacodigo |;

lineacodigo		: lineacodigo linea | linea;

linea			: invocarmetodo ';' | crearvariable ';' | cambiarvalor ';' | buclecondicion;

invocarmetodo		: VARIABLE '(' parametrosenvio ')';

parametrosenvio		: parenvio |;

parenvio		: parenvio ',' penvio | penvio;

penvio			: valor | VARIABLE;

valor			: ENTERO | DECIMAL | BOLEANO | CADENA;

crearvariable		: tipodato VARIABLE | tipodato VARIABLE asignarvalor;

tipodato		: T_ENTERO | T_DECIMAL | T_BOLEANO | T_CADENA;

asignarvalor		: ASIGNADOR operasignacion | ASIGNADOR valor | ASIGNADOR VARIABLE;

operasignacion		: aritmetico | invocarmetodo | incredismivariable;

aritmetico		: oprcomun | oprcomun oprcomplemento;

oprcomun		: valor tipoopr valor | valor tipoopr VARIABLE | VARIABLE tipoopr valor | VARIABLE tipoopr VARIABLE;

tipoopr 		: SUMA | RESTA | MULTIPLICACION | DIVISION;

oprcomplemento		: oprcomplemento oprcom | oprcom;

oprcom			: tipoopr valor | tipoopr VARIABLE;

incredismivariable	: VARIABLE indis;

indis			: AUMENTAR | DISMINUIR;

cambiarvalor		: VARIABLE ASIGNADOR cambvalor;

cambvalor		: valor | operasignacion | VARIABLE;

buclecondicion		: condicionif | buclefor | buclewhile;

condicionif		: condicionsi | condicionsi condicionno | condicionsi condicionessino condicionno;

condicionsi		: SI '(' condicion ')' '[' lineascodigos ']';

condicion		: valor condicional valor | valor condicional VARIABLE | VARIABLE condicional valor | VARIABLE condicional VARIABLE;

condicional		: MAYOR | MENOR | IGUAL | MAYORIGUAL | MENORIGUAL | NOIGUAL;

condicionno		: NO '[' lineascodigos ']';

condicionessino		: condicionessino condicionsino | condicionsino;

condicionsino		: SINO '(' condicion ')' '[' lineascodigos ']';

buclefor		: PARA '(' iniciafor ';' condicion ';' incredismivariable ')' '[' lineascodigos ']';

iniciafor		: tipodato VARIABLE asignarvalor;

buclewhile		: MIENTRAS '(' condicion ')' '[' lineascodigos ']';

funciones		: funciones funcion | funcion;

funcion			: tiporetorno VARIABLE '(' parametrosin ')' '{' lineascodigos '}';

tiporetorno 		: tipodato | VOID;

parametrosin		: parametros |;

parametros		: parametros ',' parametro | parametro;

parametro		: tipodato VARIABLE;

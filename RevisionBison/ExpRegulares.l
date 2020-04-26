%{
#include <stdio.h>
#include <conio.h>
#include "C:\RevisionBison\analizadorlexico.h";
%}

%option noyywrap
%option yylineno

ignora " "|\t|\n
caracter [A-Za-z]
digito [0-9]
boleano "true"|"false"

%%

{ignora}*				{;}
"."					{return ('.');}
"{"					{return ('{');}
"}"					{return ('}');}
";"					{return (';');}
","					{return (',');}
")"					{return (')');}
"("					{return ('(');}
"["					{return ('[');}
"]"					{return (']');}
"if"					{return SI;}
"else if"				{return SINO;}
"else"					{return NO;}
"for"					{return PARA;}
"while"					{return MIENTRAS;}
"void"					{return VOID;}
"main"					{return MAIN;}
"int"					{return T_ENTERO;}
"decimal"				{return T_DECIMAL;}
"bool"					{return T_BOLEANO;}
"string"				{return T_CADENA;}
"+"					{return SUMA;}
"-"					{return RESTA;}
"*"					{return MULTIPLICACION;}
"/"					{return DIVISION;}
"++"					{return AUMENTAR;}
"--"					{return DISMINUIR;}
"=>"					{return ASIGNADOR;}
">"					{return MAYOR;}
"<"					{return MENOR;}
"=="					{return IGUAL;}
">="					{return MAYORIGUAL;}
"<="					{return MENORIGUAL;}
"!="					{return NOIGUAL;}
{digito}+				{return ENTERO;}
{digito}+"."{digito}			{return DECIMAL;}
{boleano}				{return BOLEANO;}
"\""({digito}|{caracter}|" ")*"\""	{return CADENA;}
{caracter}({caracter}|(digito))*	{return VARIABLE;}
.					{printf("Error en linea: %d\n",yylineno);}


%%

yyerror(char * msg)
{
printf("%s\n",msg);
}

int main(void)
{
char NombreArchivo[50];
printf("Ruta del archivo: ");
gets(NombreArchivo);
yyin=fopen(NombreArchivo,"rt");
if(yyin==NULL)
printf("\nNo se puede leer el archivo");
else
yyparse();
fclose(yyin);
getch();
}

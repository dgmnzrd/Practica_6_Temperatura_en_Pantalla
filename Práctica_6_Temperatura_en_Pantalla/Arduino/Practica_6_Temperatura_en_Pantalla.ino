/*:-----------------------------------------------------------------------------
 *:                       INSTITUTO TECNOLOGICO DE LA LAGUNA
 *:                     INGENIERIA EN SISTEMAS COMPUTACIONALES
 *:                             SISTEMAS PROGRAMABLES           
 *:                                   Ago-Dic 2024
 *:               
 *:                      Practica 6 Temperatura en Pantalla
 *: 
 *: INTEGRANTES: Diego Muñoz Rede
 *:              Leonardo Zavala Gonzalez
 *:              Alejandro Cabrera Mendez
 *:---------------------------------------------------------------------------*/
#include <SoftwareSerial.h>
byte rx = 10;
byte tx = 11;
SoftwareSerial bt( rx, tx );
float temperatura;

void setup() 
{
  Serial.begin( 9600 );
  bt.begin( 9600 );
}

void loop() 
{
  int valorArduino = analogRead( A0 );
  temperatura = ( 5.0 * valorArduino * 100.0 ) / 1024.0;

  bt.println( temperatura );

  delay( 1000 );  // Envía los datos cada segundo
}


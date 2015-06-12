using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    [Category("Test")]
    internal class SampleTests
    {
       		
		[Test]
		[Category("Test de Tablero")]
		public void testearTableroPartidaGanada(){

			Debug.Log ("Comienzan a ejecutarse los test sobre el tablero.");

			Board tablero = (Board) GameObject.Find ("game").GetComponent ("Board");

			//Test 1 (Test Vertical)
			tablero.Start ();
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (0);
			Assert.That (tablero.getGameState() == 1);

			//Test 2 (Test Horizontal)
			tablero.Start ();
			tablero.addFicha (0);
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (1);
			tablero.addFicha (2);
			tablero.addFicha (2);
			tablero.addFicha (3);
			Assert.That (tablero.getGameState() == 1);
			
			//Test 3 (Test Diagonal 1)
			tablero.Start ();
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (1);
			tablero.addFicha (2); 
			tablero.addFicha (2);
			tablero.addFicha (3);
			tablero.addFicha (2);
			tablero.addFicha (3);
			tablero.addFicha (4);
			tablero.addFicha (3);
			tablero.addFicha (3);
			Assert.That (tablero.getGameState() == 1);
			
			//Test 4 (Test Diagonal 2)
			tablero.Start ();
			tablero.addFicha (3);
			tablero.addFicha (2);
			tablero.addFicha (2);
			tablero.addFicha (1);
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (1);
			tablero.addFicha (0);
			tablero.addFicha (4);
			tablero.addFicha (0);
			tablero.addFicha (0);
			Assert.That (tablero.getGameState() == 1);
			
			//Test 5 (Gana el rojo)
			tablero.Start ();
			tablero.addFicha (0);
			tablero.addFicha (1);
			tablero.addFicha (0);
			tablero.addFicha (2);
			tablero.addFicha (1);
			tablero.addFicha (3);
			tablero.addFicha (0);
			tablero.addFicha (4);
			Assert.That (tablero.getGameState() == 2);

		}
		
		[Test]
		[Category("Test de Tablero")]
		public void testearTableroPartidaEmpatada(){

			Debug.Log ("Comienzan a ejecutarse los test sobre el tablero.");

			Board tablero = (Board) GameObject.Find ("game").GetComponent ("Board");

			//Test 1 (Empate)
			tablero.Start ();
			
			for (int j = 0; j < 7; j++)
				tablero.addFicha (3);
			
			for (int j = 0; j < 3; j++){
				tablero.addFicha (2);
				tablero.addFicha (4);
			}
				
			for (int j = 0; j < 3; j++){
				tablero.addFicha (4);
				tablero.addFicha (2);
			}
			
			for (int j = 0; j < 3; j++){
				tablero.addFicha (0);
				tablero.addFicha (1);
			}
			
			for (int j = 0; j < 3; j++){
				tablero.addFicha (1);
				tablero.addFicha (0);
			}
			
			for (int j = 0; j < 3; j++){
				tablero.addFicha (5);
				tablero.addFicha (6);
			}
			
			for (int j = 0; j < 3; j++){
				tablero.addFicha (6);
				tablero.addFicha (5);
			}
			
			Assert.That (tablero.getGameState() == 0);

			
		}
    }
}

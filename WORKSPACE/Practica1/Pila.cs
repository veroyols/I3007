﻿/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 21:34
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	public class Pila : Coleccionable { //LIFO
		
		private List<Comparable> elementos;
	
		public List<Comparable> Elementos { //declara propiedad pública
			set { elementos = value; } //se ejecuta al escribir
			get { return elementos; } //se ejecuta al leer 
		}
	
		public Pila() {
			elementos = new List<Comparable>();  
		}
		
		public int cuantos() { //cantidad de elementos
			return elementos.Count;
		}

		
		public Comparable minimo() { //elemento de menor valor de la colección
			if (cuantos() == 0) {
				return null;
			}
			Comparable min = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMenor(min) ) {
					min = elementos[i];
				}
			}
			return min; 
		}
		
		public Comparable maximo() { //elemento de mayor valor de la colección
			if (cuantos() == 0) { //validacion
				return null;
			}
			Comparable max = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMayor(max) ) {
					max = elementos[i];
				}
			}
			return max; 
		}		
	
		public void agregar(Comparable objeto) {
			elementos.Add(objeto);	
		}
		
		public bool contiene(Comparable objeto) { //verdadero si el parámetro pertenece
			bool cont = false;
			if ((objeto.GetType()).Equals(new Numero().GetType())) { //comparo si es numero
				foreach (object element in elementos) {
					if ((((Numero)element).getValor) == (((Numero)objeto).getValor)) 
						cont = true;
				}
			return cont; 
			}
			if ((objeto.GetType()).Equals(new Persona().GetType())) { 
				foreach (object element in elementos) {
					if ((((Persona)element).getDni) == (((Persona)objeto).getDni)) 
						cont = true;
				}
			return cont; 
			}
			return false;
		}
	}
}

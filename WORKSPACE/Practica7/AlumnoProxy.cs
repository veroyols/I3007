﻿/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/6/2021
 * Hora: 23:55
 * 
 */
using System;

namespace Practica7 {
	
	public class AlumnoProxy : IAlumno, Comparable {
		
		protected Alumno alumnoReal = null;
		
		protected string nombre;
		protected int calificacion;		
		protected int legajo;
//		protected GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio(); //TODO
		protected EstrategiaDeComparacion estrategia = new PorCalificacion();
		protected ObtenerDatos datos = new ObtenerDatos();					
	
		public AlumnoProxy () {
			this.nombre = datos.getManejador.stringAleatorio(4);
			this.calificacion = datos.getManejador.numeroAleatorio(10);
			this.legajo = datos.getManejador.numeroAleatorio(9999);
		}
		
		public virtual int responderPregunta(int pregunta) {
				if (alumnoReal != null) {
					return alumnoReal.responderPregunta(pregunta);	
			}
			else {
				alumnoReal = new Alumno(nombre, legajo, calificacion,estrategia);
				Console.WriteLine("Crear AlumnoProxy");
				return alumnoReal.responderPregunta(pregunta);
			}
		}
		public string mostrarCalificacion() {
			return nombre + " " + calificacion;
		}
		public int getLegajo() {
			return legajo;
		}
		public int getCalificacion() {
			return calificacion;
		}
		public void setCalificacion(int calificacion) {
			this.calificacion = calificacion;
			return;
		}
		public string getNombre() {
			return nombre;
		}
		public bool sosIgual(Comparable objeto) { 
			return alumnoReal.sosIgual(objeto);
		}
		public bool sosMenor(Comparable objeto) {
			return alumnoReal.sosIgual(objeto);
		}
		public bool sosMayor(Comparable objeto) {
			return alumnoReal.sosIgual(objeto);
		}	
		public void agregarHijo(IAlumno hijo) {
			return;
		}		
	}
	public class AlumnoProxyEstudioso : AlumnoProxy {
				
		public AlumnoProxyEstudioso () : base () { }
		
		public override int responderPregunta(int pregunta) {	
				if (alumnoReal != null) {
					return alumnoReal.responderPregunta(pregunta);	
			}
			else {
				alumnoReal = new AlumnoMuyEstudioso(nombre, legajo, calificacion, estrategia);
				Console.WriteLine("Crear AlumnoProxyEstudioso");
				return alumnoReal.responderPregunta(pregunta);
			}
		}
	}
}


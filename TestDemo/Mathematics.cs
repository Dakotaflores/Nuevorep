
using System.Runtime.CompilerServices;

namespace TestDemo; 
public static class Mathematics { 
//Area de un lote
public static int Areadeunlote(int frente, int largo) { 
return (frente * largo); 
} 

//Volumen de un cubo
public static int VolumenCubo(int ancho, int largo, int altura) { 
return (ancho * largo * altura); 
} 

//Volumen metros cubicos a litros
public static double Volumenm3al(double volumen) { 
double multip = 1000; 
/*for (int count = 1; count <= num; count++) { 
sum = count * count; 
} */
return (volumen * multip); 
} 

//Conversion de litros a metros cubicos
public static double VolumenMaL(double litros) { 
    double divid = 1000;
return (litros / divid); 
} 

//Conversion de metros a kilometros
public static double ConvMaKm(double magnitud_b, double magnitud_c, double magnitud_e) { 
    double num = magnitud_c * magnitud_e;
    double result = num / magnitud_b;
return (result); 
} 

//Longitud de la rampilla(hipotenusa)
public static float Longitud_rampla(float altura, float largo) {
    float num_1 = (altura * altura);
    float num_2 = (largo * largo);
    float num_3 = (num_1 + num_2);
    float num_final = Math.Sqrt(num_3);
return (num_final); 
} 
public static double Division(double num1, double num2) { 
return (num1 / num2); 
} 
} 



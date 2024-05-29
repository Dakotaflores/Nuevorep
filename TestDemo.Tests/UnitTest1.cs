
namespace TestDemo.Tests; 
public class UnitTest1 { 
[Fact] 
public void Areadeeunlote() { 
    //Calculo del area de un lote(rectangulo)
//Arrange 
int frente = 6; 
int largo = 160;
int expectedResult = 960;
//Act 
int result = Mathematics.Areadeunlote(frente, largo); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void VolumenCubo() { 
    //Calculo del volumen de un cubo
//Arrange 
int ancho = 7;
int largo = 5;
int altura = 2; 
int expectedResult = 70;
//Act 
int result = Mathematics.VolumenCubo(ancho, largo, altura); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void Volumenm3al() { 
    //Calculo de conversion de metros cubicos a litros
//Arrange 
double volumen  = 36; 
double expectedResult = 36000;
//Act 
double result = Mathematics.Volumenm3al(volumen); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void VolumenMaL() {
    //Calculo de conversion de litros a metros cubicos
//Arrange 
double litros = 35000; 
double expectedResult = 35; 
//Act 
double result = Mathematics.VolumenMaL(litros); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void ConvMaKm() { 
    //Conversion de metros a kilometros
//Arrange 
double magnitud_b = 1000; 
double magnitud_e = 1;
double magnitud_c = 16165; 
double expectedResult = 16.165;
//Act 
double result = Mathematics.ConvMaKm(magnitud_b, magnitud_e, magnitud_c); //Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void Longitud_rampla() { 
//Arrange 
double altura
double largo = 10; 
float expectedResult = 10.44; 
//Act 
float result = Mathematics.Longitud_rampla(altura, largo); //Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void DivisionOfNumber() { 
//Arrange 
var num1 = 10; 
var num2 = 2; 
var expectedResult = 5; 
//Act 
var result = Mathematics.Division(num1, num2); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
} 

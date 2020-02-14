using System;

namespace ControldeExcepciones
{
    class Excepciones
    {       
        
        public void Ingresa()
        {
            bool berror = false;
            do
            {
                try
                {
                    berror = false;
                    Console.WriteLine("Ingresa tu Edad");
                    byte num = byte.Parse(Console.ReadLine());
                    if( num < 12 || num > 80  )
                    {
                        String edadError ="Error " + num + " no es una edad válida";
                        throw new ApplicationException(edadError);//Lanza la excepción pesonalizada o voluntaria del programador
                    }

                    num++;
                    Console.WriteLine("{0}", num);
                }
                catch(ApplicationException error )
                {
                    berror = true;
                    Console.WriteLine(error.Message);
                }
                catch (OverflowException error)
                {
                    berror = true;
                    Console.WriteLine("Error de longitud datos " + error);
                }

                catch (FormatException error)
                {
                    berror = true;
                    Console.WriteLine("Error de formato " + error.Message);
                }
                //Es una clase genérica de Excepción por default
                catch
                {
                    berror = true;
                    Console.WriteLine("Hubo un error");
                }
                finally
                {
                    Console.WriteLine("Se ejecuta aunque no exista excepción");
                }
            } while (berror); //berror ==  true    //Evalua expresiones lógicas (true ó false)

            Console.WriteLine("El número ingresado es correcto");

        }


    }
}

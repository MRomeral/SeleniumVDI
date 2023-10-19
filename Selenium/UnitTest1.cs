using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void PruebaMedusa()
        {
            ChromeOptions options = new ChromeOptions();//Opción para ignorar los certificados
            options.AddArgument("--ignore-urlfetcher-cert-requests");//Ignora la ventana de certificados
            ChromeDriver driver = new ChromeDriver(options);
            var window = driver.Manage().Window;//Controlador para la ventana
            Actions actions = new Actions(driver);
            driver.Url = "https://app.serviciosinternos.hacienda.gob.es/Medusa.MiFicha/";//Accede a esta web
            window.Maximize();// Maximiza la ventana
            WebElement btnAcceder = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div"));
            btnAcceder.Click();
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement btnFichar = (WebElement)driver.FindElement(By.Id("Contenido_btnMarcaje"));
            btnFichar.Click();
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement btnAceptarFichar = (WebElement)driver.FindElement(By.Id("Contenido_btnAceptarMarcaje"));
            btnAceptarFichar.Click();
            Thread.Sleep(5000);//Espera 5 segundos
            foreach (string win in driver.WindowHandles)//bucle que cierra todas las ventanas abiertas durante la prueba
            {
                driver.SwitchTo().Window(win);
                driver.Close();
            }
        }



        [TestMethod]
        public void pruebaRN()
        {
            ChromeOptions options = new ChromeOptions();//Opción para ignorar los certificados
            options.AddArgument("--ignore-urlfetcher-cert-requests");//Ignora la ventana de certificados
            ChromeDriver driver = new ChromeDriver(options);
            var window = driver.Manage().Window;//Controlador para la ventana
            Actions actions = new Actions(driver);
            driver.Url = "https://preapp.serviciosinternos.hacienda.gob.es/RegistroNET/";//Accede a esta web
            window.Maximize();// Maximiza la ventana
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement btnAcceder = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div"));
            btnAcceder.Click();
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement btnRegistro = (WebElement)driver.FindElement(By.Id("btnAcceder6"));
            btnRegistro.Click();
            Thread.Sleep(5000);//Espera 5 segundos
            driver.Url = "https://preapp.serviciosinternos.hacienda.gob.es/RegistroNET//Registros/AltaRegistros.aspx?TipoRegistro=1";
            Thread.Sleep(5000);//Espera 5 segundos
            //driver.Close();
            WebElement listaEntrada = (WebElement)driver.FindElement(By.Id("ui-state-default ui-combobox-input ui-autocomplete-input ui-widget ui-widget-content ui-corner-left"));
            

            foreach (string win in driver.WindowHandles)//bucle que cierra todas las ventanas abiertas durante la prueba
            {
                driver.SwitchTo().Window(win);
                driver.Close();
            }
        }



        [TestMethod]
        public void pruebaDIR3NET()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-urlfetcher-cert-requests");//Ignora la ventana de certificados
            ChromeDriver driver = new ChromeDriver(options);
            var window = driver.Manage().Window;//Controlador para la ventana
            Actions actions = new Actions(driver);
            driver.Url = "https://preapp.serviciosinternos.hacienda.gob.es/DIR3.NET/";//Accede a esta web
            window.Maximize();// Maximiza la ventana
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement btnAcceder = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div"));
            btnAcceder.Click();
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement textoBusqueda = (WebElement)driver.FindElement(By.CssSelector("#txtBuscar"));
            textoBusqueda.Clear();
            textoBusqueda.SendKeys("Cuenca");
            Thread.Sleep(5000);//Espera 5 segundos
            

            //WebElement btnBuscar = (WebElement)driver.FindElement(By.Id("btnBuscar"));
            //btnBuscar.Click();
            
            foreach (string win in driver.WindowHandles)//bucle que cierra todas las ventanas abiertas durante la prueba
            {
                driver.SwitchTo().Window(win);
                driver.Close();
            }
        }



        [TestMethod]
        public void pruebaPALMER()
        {
            ChromeOptions options = new ChromeOptions();//Opción para ignorar los certificados
            options.AddArgument("--ignore-urlfetcher-cert-requests");//Ignora la ventana de certificados
            ChromeDriver driver = new ChromeDriver(options);
            var window = driver.Manage().Window;//Controlador para la ventana
            Actions actions = new Actions(driver);
            driver.Url = "https://app.serviciosinternos.hacienda.gob.es/Palmer/Expedientes_Filtrado.aspx/";//Accede a esta web
            window.Maximize();// Maximiza la ventana
            Thread.Sleep(5000);//Espera 5 segundos
            WebElement btnAcceder = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div"));
            btnAcceder.Click();
            Thread.Sleep(5000);//Espera 5 segundos
        }

        [TestMethod]
        public void AltaPapirus()
        {
            //Generador aleatorio
            Random rnd = new Random();

            ChromeOptions options = new ChromeOptions();//Opción para ignorar los certificados
            options.AddArgument("--ignore-urlfetcher-cert-requests");//Ignora la ventana de certificados
            ChromeDriver driver = new ChromeDriver(options);
            var window = driver.Manage().Window;//Controlador para la ventana
            Actions actions = new Actions(driver);
            driver.Url = "https://intapp.serviciosinternos.hacienda.gob.es/Papirus/";//Accede a esta web
            window.Maximize();// Maximiza la ventana
            Thread.Sleep(5000);//Espera 5 segundos

            //Accede a la aplicación a través de Hermes
            WebElement btnAcceder = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div"));
            btnAcceder.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Accede al apartado recursos
            WebElement btnRecursos = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/div/app-menu/nav/ul/li[1]/a/span"));
            btnRecursos.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Despliega el menú
            WebElement btnMenu = (WebElement)driver.FindElement(By.ClassName("ver-menu"));
            btnMenu.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Accede al menú de Alta Recurso
            WebElement btnAlta = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/aside/app-sub-menu/div/nav/ul/li[1]/a"));
            btnAlta.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Seleccionmos elementos en Datos Generales
            WebElement listaAlta = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[1]/div[1]/mat-form-field[1]/div/div[1]/div/mat-select"));
            listaAlta.Click();//Hemos cambiado el id que es mat-select-0

            String[] opcionesAlta = new String[5];
            opcionesAlta[0] = "/html/body/div[2]/div[2]/div/div/div/mat-option[2]";//Función Pública
            opcionesAlta[1] = "/html/body/div[2]/div[2]/div/div/div/mat-option[3]";//Hacienda
            opcionesAlta[2] = "/html/body/div[2]/div[2]/div/div/div/mat-option[4]";//Política Territorial
            opcionesAlta[3] = "/html/body/div[2]/div[2]/div/div/div/mat-option[5]";//Impuesto de Sociedades
            opcionesAlta[4] = "/html/body/div[2]/div[2]/div/div/div/mat-option[6]/";//Plusvalías
            int opcionAlta = rnd.Next(0, 4);

            var opAlta = driver.FindElement(By.XPath(opcionesAlta[opcionAlta]));//Por defecto elige Función Pública
            opAlta.Click();
            Thread.Sleep(500);

            WebElement listaSubAlta = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[1]/div[1]/mat-form-field[2]/div/div[1]/div/mat-select"));
            listaSubAlta.Click();
            String[] opcionesSubAlta = new String[5];
            var opSubAlta = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/mat-option/span"));
            
            if (opAlta.Equals(opcionesAlta[0]))
            {
                opcionesSubAlta[0] = "/html/body/div[2]/div[2]/div/div/div/mat-option[2]";
            }else if (opAlta.Equals(opcionesAlta[1]))
            {
                
                opcionesSubAlta[1] = "/html/body/div[2]/div[2]/div/div/div/mat-option[2]";
                opcionesSubAlta[2] = "/html/body/div[2]/div[2]/div/div/div/mat-option[3]";
                opcionesSubAlta[3] = "/html/body/div[2]/div[2]/div/div/div/mat-option[4]";
                int opcion = rnd.Next(1, 3);
                opSubAlta = driver.FindElement(By.XPath(opcionesSubAlta[opcion]));
            }
            else if(opAlta.Equals(opcionesAlta[3]) || opAlta.Equals(opcionesAlta[4]))
            {
                opSubAlta = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/mat-option"));
            }           
            

            
            opSubAlta.Click();
            Thread.Sleep(500);

            //Lista de tramitadores
            WebElement listaTram = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[1]/div[2]/mat-form-field[1]/div/div[1]/div/mat-select"));
            listaTram.Click();
            String[] opcionesTram = new string[16];
            opcionesTram[0] = "/html/body/div[2]/div[2]/div/div/div/mat-option[2]/span";
            opcionesTram[1] = "/html/body/div[2]/div[2]/div/div/div/mat-option[3]/span";
            opcionesTram[2] = "/html/body/div[2]/div[2]/div/div/div/mat-option[4]/span";
            opcionesTram[3] = "/html/body/div[2]/div[2]/div/div/div/mat-option[5]/span";
            opcionesTram[4] = "/html/body/div[2]/div[2]/div/div/div/mat-option[6]/span";
            opcionesTram[5] = "/html/body/div[2]/div[2]/div/div/div/mat-option[7]/span";
            opcionesTram[6] = "/html/body/div[2]/div[2]/div/div/div/mat-option[8]/span";
            opcionesTram[7] = "/html/body/div[2]/div[2]/div/div/div/mat-option[9]/span";
            opcionesTram[8] = "/html/body/div[2]/div[2]/div/div/div/mat-option[10]/span";
            opcionesTram[9] = "/html/body/div[2]/div[2]/div/div/div/mat-option[11]/span";
            opcionesTram[10] = "/html/body/div[2]/div[2]/div/div/div/mat-option[12]/span";
            opcionesTram[11] = "/html/body/div[2]/div[2]/div/div/div/mat-option[13]/span";
            opcionesTram[12] = "/html/body/div[2]/div[2]/div/div/div/mat-option[14]/span";
            opcionesTram[13] = "/html/body/div[2]/div[2]/div/div/div/mat-option[15]/span";
            opcionesTram[14] = "/html/body/div[2]/div[2]/div/div/div/mat-option[16]/span";
            int opcionTram = rnd.Next(0, 14);
            var opTram = driver.FindElement(By.XPath(opcionesTram[opcionTram]));
            opTram.Click();
            Thread.Sleep(500);

            //Lista de recursos
            WebElement listaRec = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[1]/div[2]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[1]"));
            listaRec.Click();//mat-select-8
            var opRec = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/mat-option[3]"));
            opRec.Click();
            Thread.Sleep(500);

            //Añadimos un interesado 
            WebElement btnAnaInt = (WebElement)driver.FindElement(By.CssSelector("body > app-root > main > app-recurso > div > div > app-register-recurso > section > form > div.formContainer > fieldset:nth-child(2) > div > app-interesados > app-interesado > div > button"));
            btnAnaInt.Click();//Abrimos la ventana de añadir interesado
            Thread.Sleep(1000);

            WebElement listaTI = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[1]/mat-form-field[1]/div/div[1]/div/mat-select/div/div[1]"));
            listaTI.Click();//mat-select-24
            var opTI = driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/mat-option[2]"));
            opTI.Click();//Elegimos al tipo de interesado
            Thread.Sleep(500);

            WebElement listaTId = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[1]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[1]"));
            listaTId.Click();//mat-select-26
            var opTId = driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/mat-option[2]"));
            opTId.Click();//Elegimos el tipo de identificacion
            Thread.Sleep(500);

            WebElement DNIPrueba = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[1]/mat-form-field[3]/div/div[1]/div/input"));
            DNIPrueba.Clear();
            DNIPrueba.SendKeys("00000011A");

            WebElement nombrePrueba = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[2]/mat-form-field[1]/div/div[1]/div/input"));
            nombrePrueba.Clear();
            nombrePrueba.SendKeys("Pepe");
            Thread.Sleep(200);

            WebElement ap1Prueba = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[2]/mat-form-field[2]/div/div[1]/div/input"));
            ap1Prueba.Clear();
            ap1Prueba.SendKeys("Probador");
            Thread.Sleep(200);

            WebElement ap2Prueba = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[2]/mat-form-field[3]/div/div[1]/div/input"));
            ap2Prueba.Clear();
            ap2Prueba.SendKeys("De Papirus");
            Thread.Sleep(200);

            //Tachamos la opción de principal
            WebElement esPrincipal = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/fieldset/div[1]/mat-slide-toggle/label/div/div/div[1]"));
            esPrincipal.Click();
            Thread.Sleep(200);

            //Guardamos los datos y cerramos la ventana
            WebElement btnGuardarInt = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-register-interesado/form/div/button[1]"));
            btnGuardarInt.Click();//Abrimos la ventana de añadir interesado
            

            Thread.Sleep(200);//Espera 5 segundos

            //Escribimos el nombre del representante
            WebElement nombreRepresentante = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[3]/app-representantes/app-representante/div[2]/mat-form-field/div/div[1]/div/input"));
            nombreRepresentante.SendKeys("Prueba de Representante");
            Thread.Sleep(200);

            //Introducimos la fecha de entrada
            WebElement fechaEntrada = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[4]/div/mat-form-field[3]/div/div[1]/div[1]/input"));
            fechaEntrada.SendKeys(DateTime.Now.ToString("dd/MM/yyyy"));
            Thread.Sleep(200);

            //Añadimos centro
            WebElement btnAnaCen = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[4]/app-centros-recurso/div[1]/button"));
            btnAnaCen.Click();//Abre la ventana del centro
            Thread.Sleep(1000);

            WebElement arbolDIR3 = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[1]/mat-radio-group/mat-radio-button[2]/label/span[1]"));
            arbolDIR3.Click();//Pulsa el botón de DIR3
            Thread.Sleep(2000);

            WebElement listaAP = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[2]/mat-form-field[1]/div/div[1]/div/mat-select/div/div[1]"));
            listaAP.Click();//Hace Click en qué tipo de Administración queremos
            var opAP = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/mat-option[4]/span"));
            opAP.Click();
            Thread.Sleep(2000);

            WebElement listaMin = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[2]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[1]/span"));
            listaMin.Click();//Hace click en el listado de ministerios
            var opMin = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/mat-option[25]"));
            opMin.Click();
            Thread.Sleep(200);

            //Busca un DIR3 concreto
            //WebElement textoDIR3 = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[2]/mat-form-field[3]/div/div[1]/div/input"));
            //textoDIR3.SendKeys("E05029501");//GABSEH


            WebElement btnBuscarAP = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[3]/button[1]"));
            btnBuscarAP.Click();
            Thread.Sleep(5000);

            //Botón desplegable Ministerio
            WebElement btnDesplegable = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[4]/mat-tree/mat-nested-tree-node/div[1]/button[1]"));
            btnDesplegable.Click();
            Thread.Sleep(5000);

            //Selecciona GABSEH 
            WebElement btnOrganismo = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-buscadordir3/section/form/div[4]/mat-tree/mat-nested-tree-node/div[2]/mat-tree-node[5]/button"));
            btnOrganismo.Click();
            Thread.Sleep(1000);

            if (listaRec.Equals("/html/body/div[2]/div[2]/div/div/div/mat-option[2]"))//Administrativo
            {
                WebElement tipoProcedimiento = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[5]/div[1]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[1]"));
                tipoProcedimiento.Click();
                var opTipoProcedimiento = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/mat-option[2]"));
                opTipoProcedimiento.Click();
                Thread.Sleep(200);

                WebElement tipoMateria = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[5]/div[1]/mat-form-field[3]/div/div[1]/div/mat-select/div"));
                tipoMateria.Click();
                var opTipoMateria = (WebElement)driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/mat-option"));
                Thread.Sleep(500);

                //Hace click sobre EsResolución
                WebElement esResolucion = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/div/app-register-recurso/section/form/div[1]/fieldset[7]/div[2]/mat-slide-toggle/label/div/div"));
                esResolucion.Click();
            }
            else if(listaRec.Equals("/html/body/div[2]/div[2]/div/div/div/mat-option[3]"))//Contencioso
            {

            }
            else
            {

            }
            Thread.Sleep(2000);

            foreach (string win in driver.WindowHandles)//bucle que cierra todas las ventanas abiertas durante la prueba
            {
                driver.SwitchTo().Window(win);
                driver.Close();
            }
        }

        [TestMethod]
        public void BuscarPapirus()
        {
            //Generador aleatorio
            Random rnd = new Random();

            ChromeOptions options = new ChromeOptions();//Opción para ignorar los certificados
            options.AddArgument("--ignore-urlfetcher-cert-requests");//Ignora la ventana de certificados
            ChromeDriver driver = new ChromeDriver(options);
            var window = driver.Manage().Window;//Controlador para la ventana
            Actions actions = new Actions(driver);
            driver.Url = "https://intapp.serviciosinternos.hacienda.gob.es/Papirus/";//Accede a esta web
            window.Maximize();// Maximiza la ventana
            Thread.Sleep(5000);//Espera 5 segundos

            //Accede a la aplicación a través de Hermes
            WebElement btnAcceder = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div"));
            btnAcceder.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Accede al apartado recursos
            WebElement btnRecursos = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/div/app-menu/nav/ul/li[1]/a/span"));
            btnRecursos.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Despliega el menú
            WebElement btnMenu = (WebElement)driver.FindElement(By.ClassName("ver-menu"));
            btnMenu.Click();
            Thread.Sleep(3000);//Espera 5 segundos

            //Accede al menú de Alta Recurso
            WebElement btnBuscador = (WebElement)driver.FindElement(By.XPath("/html/body/app-root/main/app-recurso/div/aside/app-sub-menu/div/nav/ul/li[2]/a"));
            btnBuscador.Click();
            Thread.Sleep(3000);//Espera 5 segundos
        }
    }
}

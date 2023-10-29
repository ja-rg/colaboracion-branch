using log4net;
using log4net.Config;
using static System.Net.Mime.MediaTypeNames;


XmlConfigurator.Configure(new FileInfo("log4net-config.xml"));
ILog logger = LogManager.GetLogger(typeof(Program));

logger.Info("Programa iniciando");
Console.WriteLine("Hello, World!");
logger.Info("Programa finalizando");
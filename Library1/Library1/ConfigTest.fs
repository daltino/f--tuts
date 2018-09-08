#if INTERACTIVE
#r "System.Configuration.dll"
#else
module ConfigTest
#endif

open System.Configuration

//read an application setting
let setting = ConfigurationManager.AppSettings.["MySetting"]

//print the setting
printfn "%s" setting

////get the connection string
//let connectionStringDetails = ConfigurationManager.ConnectionStrings.["MyConnectionString"]

////print the details
//printfn "%s\r\n%s" connectionStringDetails.ConnectionString connectionStringDetails.ProviderName

////open the machine config
//let config = ConfigurationManager.OpenMachineConfiguration()

////print the names of all sections
//for x in config.Sections do
//    printfn "%s" x.SectionInformation.Name
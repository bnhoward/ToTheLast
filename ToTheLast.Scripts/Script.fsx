// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#r @"bin\Debug\FSharp.Data.SqlProvider.dll"
open System
open System.Linq
open FSharp.Data.Sql

// Define your library scripting code here

type sql = SqlDataProvider< 
              ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Repos\ToTheLast\ToTheLast.Web\wwwroot\App_Data\ttl-data.mdb;Persist Security Info=False;",
              DatabaseVendor = Common.DatabaseProviderTypes.MSACCESS,
              UseOptionTypes = true >
let ctx = sql.GetDataContext()



let d=ctx.``[ttl-data].[Gig]``.Individuals.``103``.Description
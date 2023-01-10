string folderName = @"C:\Users\Vasya_Pupkin\Desktop";
 
var sb = new System.Text.StringBuilder();
string newline = Environment.NewLine;
 
 
sb = new System.Text.StringBuilder();
 
 
sb.Append("sep=;" + newline);
sb.Append("RoleName" + ';' + "TableName" + ';' + "FilterExpression" + newline);
 
foreach (var r in Model.Roles.OrderBy(a => a.Name).ToList())
{
    foreach(var t in Model.Tables.OrderBy(a => a.Name).ToList())
    {
        string rls = Model.Tables[t.Name].RowLevelSecurity[r.Name];
        if (!String.IsNullOrEmpty(rls))
        {  
            rls = rls.Replace("\n", String.Empty);
            rls = rls.Replace("\r", String.Empty);
            rls = rls.Replace("\t", String.Empty);
            sb.Append(r.Name + ';' + t.Name + ';' + rls + newline);
        }
    }
}
 
System.IO.File.WriteAllText(folderName + @"\RLS.csv", sb.ToString());

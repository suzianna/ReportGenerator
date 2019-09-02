Task("Clean")
    .Does(()=>{
      Console.WriteLine("hello world");
});

Task("Default")
    .IsDependentOn("Clean")
    ;

RunTarget("Default");
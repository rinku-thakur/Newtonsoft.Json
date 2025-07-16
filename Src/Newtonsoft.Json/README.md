# ![Logo](https://raw.githubusercontent.com/JamesNK/Autodesk.DataExchange.Newtonsoft.Json/master/Doc/icons/logo.jpg) Json.NET

[![NuGet version (Autodesk.DataExchange.Newtonsoft.Json)](https://img.shields.io/nuget/v/Autodesk.DataExchange.Newtonsoft.Json.svg?style=flat-square)](https://www.nuget.org/packages/Autodesk.DataExchange.Newtonsoft.Json/)
[![Build status](https://dev.azure.com/jamesnk/Public/_apis/build/status/JamesNK.Autodesk.DataExchange.Newtonsoft.Json?branchName=master)](https://dev.azure.com/jamesnk/Public/_build/latest?definitionId=8)

Json.NET is a popular high-performance JSON framework for .NET

## Serialize JSON

```csharp
Product product = new Product();
product.Name = "Apple";
product.Expiry = new DateTime(2008, 12, 28);
product.Sizes = new string[] { "Small" };

string json = JsonConvert.SerializeObject(product);
// {
//   "Name": "Apple",
//   "Expiry": "2008-12-28T00:00:00",
//   "Sizes": [
//     "Small"
//   ]
// }
```

## Deserialize JSON

```csharp
string json = @"{
  'Name': 'Bad Boys',
  'ReleaseDate': '1995-4-7T00:00:00',
  'Genres': [
    'Action',
    'Comedy'
  ]
}";

Movie m = JsonConvert.DeserializeObject<Movie>(json);

string name = m.Name;
// Bad Boys
```

## LINQ to JSON

```csharp
JArray array = new JArray();
array.Add("Manual text");
array.Add(new DateTime(2000, 5, 23));

JObject o = new JObject();
o["MyArray"] = array;

string json = o.ToString();
// {
//   "MyArray": [
//     "Manual text",
//     "2000-05-23T00:00:00"
//   ]
// }
```

## Links

- [Homepage](https://www.newtonsoft.com/json)
- [Documentation](https://www.newtonsoft.com/json/help)
- [NuGet Package](https://www.nuget.org/packages/Autodesk.DataExchange.Newtonsoft.Json)
- [Release Notes](https://github.com/JamesNK/Autodesk.DataExchange.Newtonsoft.Json/releases)
- [Contributing Guidelines](https://github.com/JamesNK/Autodesk.DataExchange.Newtonsoft.Json/blob/master/CONTRIBUTING.md)
- [License](https://github.com/JamesNK/Autodesk.DataExchange.Newtonsoft.Json/blob/master/LICENSE.md)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/json.net)

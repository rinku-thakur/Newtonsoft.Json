# ![Logo](https://raw.githubusercontent.com/JamesNK/Newtonsoft.Json/master/Doc/icons/logo.jpg) Autodesk DataExchange Json.NET

[![NuGet version (Autodesk.DataExchange.Newtonsoft.Json)](https://img.shields.io/nuget/v/Autodesk.DataExchange.Newtonsoft.Json.svg?style=flat-square)](https://www.nuget.org/packages/Autodesk.DataExchange.Newtonsoft.Json/)

Autodesk DataExchange fork of Json.NET - a popular high-performance JSON framework for .NET

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

- [Original Json.NET Homepage](https://www.newtonsoft.com/json)
- [Original Json.NET Documentation](https://www.newtonsoft.com/json/help)
- [Original Json.NET GitHub](https://github.com/JamesNK/Newtonsoft.Json)
- [Contributing Guidelines](https://github.com/JamesNK/Newtonsoft.Json/blob/master/CONTRIBUTING.md)
- [License](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md)

## Changes from Original
This fork maintains API compatibility with the original Json.NET while being packaged as `Autodesk.DataExchange.Newtonsoft.Json` for use in Autodesk DataExchange projects.

# Binner.SwarmApi

Provides an api interface to the [Binner Swarm Api](https://binner.io/swarm).

## Description

A C# restful client for working with the open source [Binner Swarm Api](https://binner.io/swarm).

## Usage

```csharp
using Binner.SwarmApi;

var config = new SwarmApiConfiguration();
var client = new SwarmApiClient(config);

var response = await client.GetPartInformationAsync("LM358");
// process part information results
```

### Error Handling

```csharp
using Binner.SwarmApi;

var config = new SwarmApiConfiguration();
var client = new SwarmApiClient(config);

var response = await client.GetPartInformationAsync("LM358");
if (response.IsSuccessful)
{
	// process part information results
	foreach (var part in response.Response.Parts)
	{
		Console.WriteLine($"Part Number: {part.BasePartNumber}");
		Console.WriteLine($"Type: {part.PartType}");
		Console.WriteLine($"Mfr: {part.Manufacturer} = {part.ManufacturerPartNumber}");
		Console.WriteLine($"Datasheets: {string.Join(", ", part.DatasheetUrls)}");
		Console.WriteLine();
	}
} else {
	var x = 0;
	foreach (var error in response.Errors)
	{
			x++;
			Console.WriteLine($" [{x}] {error}");
	}
}
```

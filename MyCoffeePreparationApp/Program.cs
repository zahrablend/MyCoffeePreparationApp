﻿using MyCoffeePreparationApp.FileAccess;
using MyCoffeePreparationApp.DataAccess;
using MyCoffeePreparationApp.Coffees.Ingredients;
using MyCoffeePreparationApp.Coffees;
using MyCoffeePreparationApp.App;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ? 
    new StringsJsonRepository() : 
    new StringsXmlRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata (FileName, Format);

var ingredientsRegister = new IngredientsRegister();
var coffeePreparationApp = new CoffeePreparationApp(
    new RecipesRepository(
        new StringsJsonRepository(),
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister));

coffeePreparationApp.Run(fileMetadata.ToPath());

// See https://aka.ms/new-console-template for more information
using IrisML;

Console.WriteLine("Hello, World!");

//Load sample data
var sampleData = new MLModel_Iris.ModelInput()
{
    Sepallength = 5.1F,
    Sepalwidth = 3.5F,
    Petallength = 1.4F,
    Petalwidth = 0.2F,
};

//Load model and predict output
var result = MLModel_Iris.Predict(sampleData);
Console.Out.WriteLine(result.Prediction);

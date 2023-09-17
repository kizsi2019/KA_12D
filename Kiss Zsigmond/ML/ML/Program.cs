// See https://aka.ms/new-console-template for more information
using ML;

Console.WriteLine("Hello, World!");
//Load sample data
var sampleData = new MLModel1.ModelInput()
{
    Phone_name = @"K20 plus",
    Brand = @"LG",
    Os = @"Android 7.0",
    Resolution = @"720x1280",
    Battery = 2700F,
    Battery_type = @"Li-Ion",
    Ram_GB_ = 2F,
    Announcement_date = @"2016-12-01",
    Storage_GB_ = 16F,
    Video_720p = false,
    Video_1080p = true,
    Video_8K = @"False",
    Video_30fps = @"True",
    Video_60fps = false,
    Video_120fps = false,
    Video_240fps = false,
    Video_480fps = @"False",
    Video_960fps = false,
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
Console.WriteLine("4K-s phone? "+ result.PredictedLabel);
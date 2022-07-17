# PersianConsole
a package for showing Persian-Arabic text in Console correctly
#### why this package?
Sometimes there are situations where you want to see texts in the console that the console does not support.
You can use this very small package for this
<sub>*For example, I want this package to display Telegram bot logs on the console whene the bot is in the Iranian group.*</sub>

**an important tip :** *In this document, I have used the term **Farsi** to use the methods of this package, but this package supports **all right align languages**.*

to **install** :
`dotnet add package PersianConsole --version 1.0.0`

to **use** :
```csharp
using PersianConsole;
```

### start of work

To display Farsi texts in the console, you must call **Enable** method first
<sub>*This method does not get any parameters*</sub>
```csharp
ConvertConsole.Enable();
```
<sub>now you can use other methods</sub>

## methods
currently there are only two main method 

|method|description|
|---|---|
|`ConvertString()`|to convert texts(strings) to persian font|
|`ConvertList()`|to convert list items to persian font

### ConvertString()
This method actually reverses the text
If you don't call this method, you'll get a result like this: `مالس`
But if you use this method in your code, your result is correct: `سلام`
<sub>*This method get one parameter with **`string`** type 
the parameter is the text that you want to display Farsi*</sub>

see this examples :

```csharp
using PersianConsole;

ConvertConsole.Enable(); //now you can see persian fonts
string text = "سلام";
Console.WriteLine(text); //we don't call ConvertString() method
```
output is : ` مالس`


And see this example where we use the `ConvertString()` method
```csharp
using PersianConsole;

ConvertConsole.Enable(); //now you can see persian fonts
string text = "سلام";
Console.WriteLine(ConvertConsole.ConvertString(text)); //We called the ConvertString() method

```
and output : `سلام`

### ConvertList()
This method actually reverses the text of the list items
And for this, it uses the `ConvertString()` method in itself.
<sub>*This method get one parameter with any list types like `array or IEnumerable`
the parameter is the list that you want to display its items Farsi*</sub>

you give that method a list ***no matter that's an array or list or IEnumerable*** and this method reverse items text ***output always is a list***, see this example without `ConvertList()`:
```charp
using PersianConsole();

ConvertConsole.Enable();
string[] names = {"فارسی","سلام","ایران"};

foreach(string item in names){
    Console.WriteLine(item); //we dont use ConvertList() method here
}
```
output is :
```
یسراف
مالس
ناریا
```

but if you call `ConvertList()` method, your items will be displayed correctly
see this example with `ConvertList()`:
```csharp
using PersianConsole();

ConvertConsole.Enable();
string[] names = {"فارسی","سلام","ایران"};
List<string> convertedNames = ConvertConsole.ConvertList(names);//we call convertList method here

foreach(string item in convertedNames){
    Console.WriteLine(item);
}
```

output is :
```
فارسی
سلام
ایران
```

### End of work
to disable this package and this options in your console app you can call **Disable()**  method.

```csharp
using PersianConsole;

ConvertConsole.Disable();
```
if you call this method you can't see any of non English texts in your console application.

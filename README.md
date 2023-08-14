# Software 1 - Class Exercise 2
## Goals
- Learn how to use the 2 most commonly used collections: List and Dictionary.

## Instructions
In the last exercise we added a function to add a product to store. I this exercise, we're going to expand on that as well as add a new function to view our product list.

1. We're going to add a new class to handle all of our product functionality.  Add a new class called `ProductLogic`. 
1. In this class, add a new _private_ variable called "products" of type `List<Product>`.  Remember to add an underscore `_` before the name because it's a private variable.
1. Create a constructor for the class and in that constructor, create a new instance of the list class.  It should look something `_products = new List<Product>();`
1. Create a new function/method called `AddProduct`.  It should have no return type (so it'll return `void`) and accept one _argument_ called "product" and it should be of type `Product`. So the method will look like this: `public void AddProduct(Product product)`
1. In that method, use the `_product` variables `Add` method to add the method's argument to the private list.
1. Next create another method called `GetAllProducts`. The method's return type will be `List<Product>` and will have no arguments.  This method will be really simple, all you have to do is return our private variable: `return _products`.
1. Back in our main "Program" class, we're going to create an _instance_ of our new `ProductLogic`.  Make it a variable at the top of the file under the `using` statments. `var productLogic = new ProductLogic();`
1. Replace the line where we are serializing the product that the user is creating with the `AddProduct()` method and pass the product the user created into the method.
1. After adding the product, add a nice message below it to let the user know that the product was added.
1. Our next major thing to add will be some dictionaries to hold our specific types of products.  So back in `ProductLogic`, add 2 more private variables.  The first will be of type `Dictionary<string, DogLeash>` and the second will be `Dictionary<string, CatFood>`.  The `string` is the key and `DogLeash`/`CatFood` are the types of objects being stored in the Dictionary.  I'll let you choose some names for these variables.
1. Now, in `AddProduct` add an if statement. It's condition will check for the _Type_ of object. If it's a `DogLeash` it will be added to the dog leash dictionary.  If it's a `CatFood` object, it will be added to the cat food dictionary.  The key will be the product's name value.  So an if statement will look like this: `if (product is DogLeash)`.
1. Inside of this if statement, use the correct dictionaries `Add` method to add the product to it.  Note: you will probably have to convert the product to the correct child class using the `as` keyword.  That would look like this: `product as DogLeash`.
1. Add another if block that does the same thing except for `CatFood` instead of `DogLeash`.
1. Add another method called `GetDogLeashByName` it will have a return type of DogLeash and will have one argument of type `string` called "name".
1. This method will use the indexing brackets `[]` to use the name key being passed in to return the object with that key in the dictionary. That would look like something this: `return _dogLeash[name]`.
1. Back in the program class, add a new option for the user.  It will be option number 2 and will let them get a specific object out of the list.  Since they're only adding a dog leash right now, we're going to just let them view a dog leash as well. Use option number 1 as a template for what you need to do right now and only use the soultion when you get stuck.
1. All you have left to do now is test your program to make sure it's working!

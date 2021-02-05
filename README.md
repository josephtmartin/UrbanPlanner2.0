# UrbanPlanner2.0
Now you need to create a type to represent your city. Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.

1. Name of the city.
2. The mayor of the city.
3. Year the city was established.
4. A collection of all of the buildings in the city.
5. A method to add a building to the city.

Remember, each class should be in its own file. Create a `City.cs` file and define the **`City`** class in there. Make sure it’s in the same namespace as your other classes.

Once the class is defined to your liking, refactor your code in `Main()` to create a new city instance and add your buildings to it. Once all buildings are in the city, refactor your code that outputs the building info to the console to be inside a `foreach` loop that iterate the city’s building collection.

### Example

```csharp
City megalopolis = new City();
...
foreach (Building building in megalopolis.Buildings) 
{    
	Console.WriteLine(...);
}
```

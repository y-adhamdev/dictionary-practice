# C# Dictionary Practice



---

### 1. Find Students by ID

Create a Dictionary containing student IDs and names.

```csharp
Dictionary<int, string> students = new()
{
    { 101, "Ali" },
    { 102, "Vali" },
    { 103, "Hasan" },
    { 104, "Husan" }
};
```

**Tasks:**

- Check whether student ID `101` exists using `ContainsKey()`.
- Check whether student ID `105` exists.
- Display both results.

### 2. Retrieve Student Information

Use the Dictionary from Exercise 1.

**Tasks:**

- Find the student with ID `102` using `TryGetValue()`.
- If the student is found, display their name.
- Otherwise, display `"Student not found"`.

### 3. Remove Students

Use the Dictionary from Exercise 1.

**Tasks:**

- Remove the student with ID `103`.
- Try to remove the student with ID `999`.
- Display the result of each `Remove()` operation.
- Display the remaining number of students using `Count`.

### 4. Search for a Non-Existing ID

Ask the user to enter a student ID.

**Tasks:**

- Read the input using `Console.ReadLine()`.
- Convert the input to an integer using `int.TryParse()`.
- Search for the student using `TryGetValue()`.
- Display an appropriate message if the input is invalid or the student does not exist.

### 5. Remove a Student If They Exist

Ask the user to enter a student ID.

**Tasks:**

- Check whether the ID exists using `ContainsKey()`.
- If it exists, remove the student using `Remove()`.
- Otherwise, display `"Student does not exist"`.

### 6. Prevent Duplicate Student IDs

Create the following Dictionary:

```csharp
Dictionary<int, string> students = new()
{
    { 101, "Ali" },
    { 102, "Vali" }
};
```

Ask the user to enter a new student ID and name.

**Tasks:**

- If the ID already exists, do not add the student.
- If the ID does not exist, add the new student.
- Display the total number of students using `Count`.

### 7. Update Student Information

Create the following Dictionary:

```csharp
Dictionary<int, string> students = new()
{
    { 101, "Ali" },
    { 102, "Vali" },
    { 103, "Hasan" }
};
```

**Tasks:**

- Ask the user to enter a student ID.
- Find the student using `TryGetValue()`.
- If the student is found, ask for a new name and update the existing value.
- Otherwise, display an appropriate message.

**Hint:** Use `students[id] = newName` to update the value associated with an existing key.

### 8. Limited Search Attempts

Allow the user to search for students three times.

**Tasks:**

- Ask the user to enter a student ID on each attempt.
- Search for the student using `TryGetValue()`.
- Display the student's name if found.
- Otherwise, display `"Student not found"`.
- At the end, display the total number of successful searches.

### 9. Product Inventory Management

Create the following Dictionary:

```csharp
Dictionary<int, string> products = new()
{
    { 1, "Laptop" },
    { 2, "Mouse" },
    { 3, "Keyboard" },
    { 4, "Monitor" }
};
```

Implement the following operations:

1. Search for a product by ID.
2. Add a new product.
3. Remove an existing product.
4. Display the total number of products.

**Requirements:**

- Use `ContainsKey()` to check whether a key exists.
- Use `TryGetValue()` to retrieve product information.
- Use `Remove()` to delete products.
- Use `Count` to display the total number of products.

### 10. User Login System

Create the following Dictionary:

```csharp
Dictionary<string, string> users = new()
{
    { "ali123", "password1" },
    { "vali456", "password2" },
    { "hasan789", "password3" }
};
```

**Tasks:**

- Ask the user to enter a username and password.
- Use `TryGetValue()` to search for the username.
- If the username does not exist, display `"User not found"`.
- If the username exists, compare the entered password with the stored password.
- If the password is correct, display `"Login successful"`.
- Otherwise, display `"Incorrect password"`.

---

##

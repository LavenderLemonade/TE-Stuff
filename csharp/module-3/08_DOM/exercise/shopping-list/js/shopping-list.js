// add pageTitle
let pageTitle = 'My Shopping List';

// add groceries
let groceries = ['Rice','Cheese','Bok Choy','Leeks','Shittake Mushrooms','Beef Belly Strips', 'Pork Belly','Soy Sauce','Chicken Thighs','Oyster Sauce']

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() 
{
    let titleGrab = document.getElementById('title');
    titleGrab.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() 
{
<<<<<<< HEAD
  unList = document.getElementById('groceries');
=======
  newList = document.getElementById('groceries');
>>>>>>> 6a3fd3b4dad03e3cadb7a9a40ff4e66b527e145e

  for (i = 0; i < groceries.length; i++)
  {
    newEntry = document.createElement('li');
    newEntry.innerText = groceries[i];
<<<<<<< HEAD
    unList.append(newEntry);
  }

  document.appendChild(newList);
=======
    newList.appendChild(newEntry);
  }

>>>>>>> 6a3fd3b4dad03e3cadb7a9a40ff4e66b527e145e

}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() 
{
  let completed = document.querySelectorAll('li');
  
  for (i = 0; i < completed.length; i++)
  {
    completed[i].classList.add('completed');
  }
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});

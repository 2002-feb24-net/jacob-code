const guesses = document.querySelector('.guesses'); //initializing constants from the classes in guessingGame html
const lastResult = document.querySelector('.lastResult');
const lowOrHi = document.querySelector('.lowOrHi');
const guessSubmit = document.querySelector('.guessSubmit');
const guessField = document.querySelector('.guessField');
const warning = document.querySelector('.warning');
const gameTitle = document.querySelector('gameTitle');

let randomNumber = Math.floor(Math.random() * 100) + 1; //Generating a random number from 1 to 100

let guessCount = 1; //initializing the guessCount
let resetButton;

function checkInput() { //Checks if the input is a valid number
    let userGuess = Number(guessField.value); //setting a number variable for the user input
    if (isNaN(userGuess)) { 
        warning.textContent = 'That was not a valid number.'; // if it is not a valid number then display a warning
        warning.style.backgroundColor = 'yellow';
    }
    else {
        checkGuess(); //if it is a valid number then check the guess
    }
}

function checkGuess() {
    warning.textContent = '';
    let userGuess = Number(guessField.value); //setting a number variable for the user input
    if (guessCount === 1) {
        guesses.textContent = 'Previous Guesses: '; //create a content to start displaying the users previous gueses.
    }

    guesses.textContent += userGuess + ' ' //add the latest guess to the guess text

    if (userGuess === randomNumber) { //if the user guesses the right answer then display a winning message
        gameTitle.textContent = "You guessed it!";
        lastResult.textContent = 'Congratulations! You got the right number!';
        //style the background green
        lastResult.style.backgroundColor = 'green'; //change last result background color to green
        lowOrHi.textContent = ''; //clear the low or high text field
    }
    else if (guessCount === 10) { //User reaches 10 guesses
        setGameOver(); //run game over function
    }
    else {
        lastResult.textContent = 'Wrong number'; //User input does not match random number
        //add styling to red for wrong number
        lastResult.style.backgroundColor = 'red'; //set last result background to red
        if (userGuess < randomNumber) {
            lowOrHi.textContent = 'That guess was too low.'; // user input was too low
        }
        else {
            lowOrHi.textContent = 'That guess was too high.'; // user input was too high
        }
    }
    guessCount++; //increment guess count
    guessField.value = ''; //clear the input box
    //refocus
    guessField.focus(); //focus the text box so it can be used again
}

guessSubmit.addEventListener('click', checkInput); //add event listener on click so checkInput runs when guessSubmit is pressed.
guessField.addEventListener("keypress", function (event) {
    if (event.key === 'Enter') {
        window.checkInput();
    }
});
function setGameOver() {
    guessField.disabled = true; //Disable user input
    guessSubmit.disabled = true;
    resetButton = document.createElement('button'); //create a reset button
    resetButton.textContent = 'Start new game';
    document.body.append(resetButton); //append the button to the page
    resetButton.addEventListener('click', resetGame); //add an event listener for the reset button
}
function resetGame() {
    guessCount = 1; //reset the guess count

    const resetParas = document.querySelectorAll('.resultParas p'); //reset all result parameters
    for (let i = 0; i < resetParas.length; i++) {
        resetParas[i].textContent = '';
    }

    resetButton.parentNode.removeChild(resetButton); //remove reset button

    guessField.disabled = false; // reenable the user input
    guessSubmit.disabled = false;
    guessField.value = ''; //reset the user input value
    guessField.focus(); //refocus for user input

    lastResult.style.backgroundColor = 'white'; //clear the last result color

    randomNumber = Math.floor(Math.random() * 100) + 1; //regenerate the random number
    gameTitle.textContent = "Number Guessing Game";
}

import CardService from "./card-service";
import Card from "./card";

export default class Page {
    cardContainer: HTMLElement | null = null;
    newDeck: HTMLElement | null = null;
    drawCard: HTMLElement | null = null;
    cardService: CardService;
    count: number | null = null;

    constructor(cardService: CardService) {
        this.cardService = cardService;

        document.addEventListener('DOMContentLoaded', () => {
            this.cardContainer = document.getElementById('card-container');
            this.newDeck = document.getElementById('new-deck');
            this.drawCard = document.getElementById('draw-card');
            this.count = 1;
        });
    }

    run() {
        document.addEventListener('DOMContentLoaded', () => {
            // set up new deck action
            this.newDeck?.addEventListener('click', () => {
                this.cardService.newDeck().then(() => {
                    // TODO: empty the card container of any existing cards
                    this.makeAjaxRequestNewDeckFetch('https://deckofcardsapi.com/api/deck/new/');
                }, (error: Error) => {
                    // TODO: display 
                        if (this.cardContainer) this.cardContainer.textContent = 'error: ' + error;
                });
            });

            // set up draw card action
            this.drawCard?.addEventListener('click', () => {
                this.cardService.drawCard().then(() => {
                    // TODO: add the card to the card container
                    this.makeAjaxRequestDrawCardWithFetch('https://deckofcardsapi.com/api/deck/3p40paa87x90/draw/?count=' + this.count);
                    if (this.count) this.count++;
                }, (error: Error) => {
                    // TODO: display error
                    if (this.cardContainer) this.cardContainer.textContent = 'error: ' + error;
                });
            });
        });
    }
    makeAjaxRequestDrawCardWithFetch(url : string) {
    // the fetch function returns a Promise of the response.
    fetch(url, { method: 'GET' })
        .then(response => response.json())
        .then(response => {
            if (this.drawCard) this.drawCard.textContent = 'Draw Card: ' + response.cards.value;
        }) 
        .catch(error => {
            if (this.drawCard) this.drawCard.textContent = 'error: ' + error;
        }); // this callback will get some error object

    // if you return a Promise in a .then callback...
    // you can chain the next aciton to take in _another_ .then
    // out at the same level

    // the Response object that the Promise resolves with
        // doesn't have the whole body yet, just the response headers
    }
    makeAjaxRequestNewDeckFetch(url: string) {
        // the fetch function returns a Promise of the response.
        fetch(url, { method: 'GET' })
            .then(response => response.json())
            .then(response => {
                if (this.cardContainer) this.cardContainer.textContent = response.cards.value;
            })
            .catch(error => {
                if (this.cardContainer) this.cardContainer.textContent = 'error: ' + error;
            }); // this callback will get some error object

        // if you return a Promise in a .then callback...
        // you can chain the next aciton to take in _another_ .then
        // out at the same level

        // the Response object that the Promise resolves with
        // doesn't have the whole body yet, just the response headers
    }

}

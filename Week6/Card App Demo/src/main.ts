//Singe page application
//itll still just have onew view pretty much but
import Page from "./page";
import CardService from "./card-service";
const cardService = new CardService();
const page = new Page(cardService);
page.run();
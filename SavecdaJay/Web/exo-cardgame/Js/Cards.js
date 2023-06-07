import { Card } from"./Card.js";
class Cards
{
    /**
     * Construit l'ojet
     * @param {String} _url Url vers l'api contenant la collection de cartes
     */
    constructor(_url)
    {
        this.cardsCollection = [];
        this.source = _url;
    }

    /* Récupère les données du fichier json
     et les stock sous forme de Card dans la cardsCollection */
    async GetCards()
    {
        let resp = await fetch(this.source);
        let json = await resp.json();
        for(let card of json)
        {
            this.cardsCollection.push(new Card(card))
        }
    }

    /**
     * retourne le 1er élément de la collection
     * @returns {Card} la 1ere carte de la collection 
     */
    getFirst()
    {
        try
        {
            return this.cardsCollection[0];
        }
        catch(error)
        {
            alert('La collection est vide !');
        }
    }

    /* 
    La methode sort prends en compte deux paramètres
    (ici nommé a et b) en fonction du retour
    si retour <0 a est avant b
    si retour = 0 a et b sont egaux 
    si retour >0 a est après B   
    */

    /**
        Retourne la carte
        @returns {Card} Carte ayant le plus d'attaque
     */
    /*. reverse sert à classer du plus grand au plus petit*/
    getHigherAttackCard()
    {
       return this.cardsCollection.sort((a,b)=> a.attack-b.attack).reverse()[0];
    }

    /**
     * Retourne la carte
     * @returns {Card} Carte avant la meilleur armure
     */

    getHigherArmorCard()
    {
        return this.cardsCollection.sort((a,b)=> a.armor-b.armor).reverse()[0];
    }

    /**
     * Retourne la carte
     * @returns {Card} Carte avant le plus été jouée
     */
    getHigherPlayedCard()
    {
        return this.cardsCollection.sort((a,b)=> a.played-b.played).reverse()[0];
    }

    /**
     * Retourne la carte
     * @returns {Card} Carte avant le plus de victoire
     */
    getHigherVictoryCard()
    {
        return this.cardsCollection.sort((a,b)=> a.victory-b.victory).reverse()[0];
    }

}
export { Cards };
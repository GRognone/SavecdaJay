import { Cards } from './Cards.js'
import { Card } from './Card.js'

const app = {
    data() {
        return {
          title: "Cardgame",
          cards: null,
          first: null,
         
        }
    },

    async mounted() {
        /** @var { Cards } cards */
        this.cards = new Cards('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
        await this.cards.getCards();
        console.log(this.cards);

      
    },

    computed: {
        cardKeys() {
            return this.cards.getFirst().getKeys();
        },

        myStats(){
            return ['attack', 'armor', 'played','victory'];
        }
    },


    //example
    // retire une lettre toutes les 2 secondes au titre.
    /*mounted() {
        setInterval(() => {
            this.title = this.title.substring(0, this.title.length-1);
        }, 2000)
    }*/

    // rajoute un a toutes les 2 secondes au titre
    /*mounted() {
        setInterval(() => {
            this.title += 'a';
        }, 2000)
    }*/

}


Vue.createApp(app).mount("#app");   
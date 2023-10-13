package com.crm.monlecteurdelistedepersonnes;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.os.Bundle;

import android.util.DisplayMetrics;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.crm.classesdomaines.Personne;

import java.util.ArrayList;


public class MainActivity extends AppCompatActivity {
ListView myListOfPerson;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ArrayList<Personne> personnes = new ArrayList<Personne>();
        personnes.add(new Personne("Gremlins", "Greta", this.getResources().getDrawableForDensity(R.drawable.furby3, DisplayMetrics.DENSITY_XHIGH)));
        personnes.add(new Personne("Schtroumpf", "Coquet"));
        personnes.add(new Personne("Dos Santos", "Manuel", this.getResources().getDrawableForDensity(R.drawable.chubaka,DisplayMetrics.DENSITY_XHIGH)));
        personnes.add(new Personne("Schtroumpf", "Coqt"));
        myListOfPerson = findViewById(R.id.ListviewMaListeDePersonne);
        /*String[] tab = new String [] {"membre1", "membre2", "membre3", "membre4", "membre5"};
        ArrayAdapter arraydp = new ArrayAdapter(this, android.R.layout.simple_list_item_1, tab);
        myListOfPerson.setAdapter(arraydp);*/
        myListOfPerson.setAdapter(new PersonneArrayAdaptater(this,personnes));
        registerForContextMenu(myListOfPerson);
        }
    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo){
        super.onCreateContextMenu(menu, v, menuInfo);

        MenuInflater inflater=getMenuInflater();
        inflater.inflate(R.menu.menu_list_personnes,menu);
    }
    @Override
    public boolean onContextItemSelected(MenuItem item) {
        // recuperer des infos supplementaires quand il y a un click long sur un item
        AdapterView.AdapterContextMenuInfo menuInfo = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();

        if (item.getItemId() == R.id.copie) {
            Toast.makeText(getApplicationContext(), "Copie: ID " + menuInfo.id + " ,position" + menuInfo.position, Toast.LENGTH_SHORT).show();
            PersonneArrayAdaptater paa = (PersonneArrayAdaptater) myListOfPerson.getAdapter();
            Personne pACopier = paa.getItem(menuInfo.position);
            ajouterFurby(pACopier);

        } else if (item.getItemId() == R.id.delete) {
            Toast.makeText(getApplicationContext(), "Delete: ID " + menuInfo.id + " ,position" + menuInfo.position, Toast.LENGTH_SHORT).show();
            PersonneArrayAdaptater paa = (PersonneArrayAdaptater) myListOfPerson.getAdapter();
            Personne pASupprimer = paa.getItem(menuInfo.position);
            paa.remove(pASupprimer);

            // rafraichir la listeView pour voir les nouveaux elements.
            paa.notifyDataSetChanged();
        }return true;
    }

    public void onAjouterUnePersonne(View v) {
    Intent intent = new Intent (this ,MainActivity2.class);
    startActivityForResult(intent,1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode,Intent intent){
        super.onActivityResult(requestCode,resultCode,intent);
        if(requestCode == 1 && resultCode== Activity.RESULT_OK){
            //Bundle b = intent.getExtras();
            String nom, prenom;
            int numPhoto;
            nom = intent.getStringExtra("nom");
            prenom = intent.getStringExtra("prenom");
            numPhoto = intent.getIntExtra("photo",0);
            Drawable drawable;
            if (numPhoto == 1){
                drawable = getResources().getDrawable(R.drawable.chubaka);
            } else if (numPhoto == 2){
                drawable = getResources().getDrawable(R.drawable.furby2);
            } else if (numPhoto == 3){
                drawable = getResources().getDrawable(R.drawable.furby3);
            } else {
                drawable = getResources().getDrawable(R.drawable.furby);
            }
            ajouterFurby(new Personne(nom, prenom, drawable));

        }
    }

    private void ajouterFurby(Personne p){
        PersonneArrayAdaptater paa = (PersonneArrayAdaptater) myListOfPerson.getAdapter();
        paa.add(p);
        paa.notifyDataSetChanged();
    }
}


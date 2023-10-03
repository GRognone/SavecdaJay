package com.crm.monlecteurdelistedepersonnes;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;

import android.util.DisplayMetrics;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import com.crm.classesdomaines.Personne;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ArrayList<Personne> personnes = new ArrayList<Personne>();
        personnes.add(new Personne("Gremlins", "Greta", this.getResources().getDrawableForDensity(R.drawable.furby3, DisplayMetrics.DENSITY_XHIGH)));
        personnes.add(new Personne("Schtroumpf", "Coquet"));
        personnes.add(new Personne("Dos Santos", "Manuel", this.getResources().getDrawableForDensity(R.drawable.chubaka,DisplayMetrics.DENSITY_XHIGH)));

        ListView myListOfPerson = findViewById(R.id.ListviewMaListeDePersonne);
        /*String[] tab = new String [] {"membre1", "membre2", "membre3", "membre4", "membre5"};
        ArrayAdapter arraydp = new ArrayAdapter(this, android.R.layout.simple_list_item_1, tab);
        myListOfPerson.setAdapter(arraydp);*/
        myListOfPerson.setAdapter(new PersonneArrayAdaptater(this,personnes));


    }
}
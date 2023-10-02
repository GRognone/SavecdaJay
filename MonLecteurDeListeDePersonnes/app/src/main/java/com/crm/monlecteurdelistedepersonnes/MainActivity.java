package com.crm.monlecteurdelistedepersonnes;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ListView myListOfPerson = findViewById(R.id.ListviewMaListeDePersonne);
        String[] tab = new String [] {"membre1", "membre2", "membre3", "membre4", "membre5"};
        ArrayAdapter arraydp = new ArrayAdapter(this, android.R.layout.simple_list_item_1, tab);
        myListOfPerson.setAdapter(arraydp);
    }
}
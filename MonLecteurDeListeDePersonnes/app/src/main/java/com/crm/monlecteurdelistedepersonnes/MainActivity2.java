package com.crm.monlecteurdelistedepersonnes;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity2 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
    }
    //recuperation des éléments de l'edittext dans l'activité 2
    public void Valider(View v){
        EditText editTextNom = findViewById(R.id.editTextNom);
        EditText editTextPrenom = findViewById(R.id.editTextPrenom);
        EditText editTextPhoto = findViewById(R.id.editTextNumPhoto);
        Intent intent = this.getIntent();
        getIntent().putExtra("nom",editTextNom.getText().toString());
        getIntent().putExtra("prenom",editTextPrenom.getText().toString());
        try {
            getIntent().putExtra("photo", Integer.valueOf(editTextPhoto.getText().toString()));
        } catch (Exception e){
            getIntent().putExtra("photo", 0);
        }
        setResult(Activity.RESULT_OK,intent);
        this.finish();
    }
}
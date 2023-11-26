package com.example.subsify.Activities;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.content.Intent;

import com.example.subsify.R;
import com.example.subsify.Util.Request;
import com.example.subsify.Util.SubscriptionRow;

import java.util.List;

public class UserHomeActivity extends AppCompatActivity {

    String username;
    String password;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_home);

        Intent intent = getIntent();
        if (intent != null) {
            username = intent.getStringExtra("username");
            password = intent.getStringExtra("password");

            Request request = new Request();
            List<SubscriptionRow> sr = request.makeApiRequest(username, password);

            RecyclerView recyclerView = findViewById(R.id.recyclerView);
            recyclerView.setLayoutManager(new LinearLayoutManager(this));

            HomeViewAdapter adapter = new HomeViewAdapter();
            recyclerView.setAdapter(adapter);
            adapter.updateList(sr);
        }
    }

}
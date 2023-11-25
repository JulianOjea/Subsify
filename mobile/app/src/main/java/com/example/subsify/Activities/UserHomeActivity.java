package com.example.subsify.Activities;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.example.subsify.R;
import com.example.subsify.Util.Request;
import com.example.subsify.Util.SubscriptionRow;

import java.util.List;

public class UserHomeActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_home);

        Request request = new Request();
        List<SubscriptionRow> sr = request.makeApiRequest();
        Log.d("ey", "ey");

        RecyclerView recyclerView = findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        HomeViewAdapter adapter = new HomeViewAdapter();
        recyclerView.setAdapter(adapter);
        adapter.updateList(sr);
    }

}
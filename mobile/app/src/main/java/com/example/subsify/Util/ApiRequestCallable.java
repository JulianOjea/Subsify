package com.example.subsify.Util;

import android.util.Base64;
import android.util.Log;

import com.google.gson.Gson;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Callable;

public class ApiRequestCallable implements Callable<List<SubscriptionRow>> {
    private static final String BASE_URL = "http://10.0.2.2:33333/subLapses/subLapseToRenew/search";
    private static final String USERNAME = "Julian";
    private static final String PASSWORD = "1234";

    @Override
    public List<SubscriptionRow> call() {
        try {
            String requestBody = "{\"columns\": [\"SUB_LAPSE_ID\",\"PLAN_ID\",\"SUBS_ID\"," +
                    "\"PLAN_PRICE_END\",\"SUB_LAPSE_END\",\"PLATF_NAME\"]}";

            URL url = new URL(BASE_URL);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();

            connection.setRequestMethod("POST");
            connection.setRequestProperty("Content-Type", "application/json");
            connection.setDoOutput(true);

            String credentials = USERNAME + ":" + PASSWORD;
            String base64Credentials = Base64.encodeToString(credentials.getBytes(), Base64.NO_WRAP);
            connection.setRequestProperty("Authorization", "Basic " + base64Credentials);

            try (OutputStream os = connection.getOutputStream()) {
                byte[] input = requestBody.getBytes("utf-8");
                os.write(input, 0, input.length);
            }

            try (BufferedReader br = new BufferedReader(new InputStreamReader(connection.getInputStream(), "utf-8"))) {
                StringBuilder response = new StringBuilder();
                String responseLine = null;
                while ((responseLine = br.readLine()) != null) {
                    response.append(responseLine.trim());
                }

                Gson gson = new Gson();
                ApiResponse apiResponse = gson.fromJson(response.toString(), ApiResponse.class);
                List<Object> data = apiResponse.getData();

                List<SubscriptionRow> result = new ArrayList<>();

                for (Object sr : data) {
                    SubscriptionRow subscriptionRow = gson.fromJson(gson.toJsonTree(sr), SubscriptionRow.class);
                    result.add(subscriptionRow);
                }
                return result;
            } finally {
                connection.disconnect();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }

}

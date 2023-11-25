package com.example.subsify.Util;

import com.google.gson.annotations.SerializedName;

public class SubscriptionRow {
    @SerializedName("PLATF_NAME")
    String platfName;

    public String getPlatfName() {
        return platfName != null ? platfName.toString() : null;
    }
}

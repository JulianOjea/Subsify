package com.example.subsify.Util;
import java.util.List;

public class ApiResponse {
    private int code;
    private String message;
    private List<Object> data;

    public int getCode() {
        return code;
    }

    public String getMessage() {
        return message;
    }

    public List<Object> getData() {
        return data;
    }
}

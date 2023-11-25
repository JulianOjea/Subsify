package com.example.subsify.Util;

import java.util.List;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.Executor;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class Request {
    public List<SubscriptionRow> makeApiRequest() {
        ExecutorService executorService = Executors.newSingleThreadExecutor();
        Future<List<SubscriptionRow>> future = executorService.submit(new ApiRequestCallable());

        try {
            return future.get();
        } catch (InterruptedException | ExecutionException e) {
            e.printStackTrace();
        } finally {
            executorService.shutdown();
        }
        return null;
    }
}

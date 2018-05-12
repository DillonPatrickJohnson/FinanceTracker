package view;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.Pane;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;


public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("financeTracker.fxml"));
        primaryStage.setTitle("Finance Tracker");


        Button button = new Button();
        button.setText("click me");
        button.setLayoutX(25);
        button.setLayoutY(25);

		Pane layout = new Pane();
		layout.getChildren().add(button);

		primaryStage.setScene(new Scene(layout, 800, 600));

		primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}

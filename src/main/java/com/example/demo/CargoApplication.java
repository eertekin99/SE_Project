package com.example.demo;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.jdbc.core.JdbcTemplate;

@SpringBootApplication
@ComponentScan(basePackages = {"com.example"})



public class CargoApplication {

    private JdbcTemplate jdbcTemplate;


    public static void main(String[] args) {
        SpringApplication.run(CargoApplication.class, args);

    }
//    INSERT INTO Customer(Name,Mobile_Phone,Address,Email,Type)
//    VALUES
//            ('Sezen Aksu', 05322003212, 'Kadıköy Numara:45', 'sezenaksu@gmail.com', 'Receiver')
//    @Override
//    public void run(String... args) throws Exception {
//        String sql ="INSERT INTO Customer(Name,Mobile_Phone,Address,Email,Type) VALUES (?, ?, ?, ?, ?)";
//        int result = jdbcTemplate.update(sql,"BurakGünnnnnnnden","05321567532","Adresim bu","none@gmail.com","Receiver");
//        if(result>0)
//            System.out.println("A new row inserteddd");
//
//    }

}

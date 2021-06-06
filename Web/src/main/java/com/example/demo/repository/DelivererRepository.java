package com.example.demo.repository;

import com.example.demo.Entity.Deliverer;
import org.springframework.data.jpa.repository.JpaRepository;

public interface DelivererRepository extends JpaRepository<Deliverer,Long> {
}

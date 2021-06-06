package com.example.demo.repository;

import com.example.demo.Entity.Cargo;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface CargoRepository extends JpaRepository<Cargo,Long> {
    Cargo findCargoByCID(long ID);


}

package com.example.demo.repository;

import com.example.demo.Entity.BranchEmployee;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BranchEmployeeRepository extends JpaRepository<BranchEmployee,Long> {
}

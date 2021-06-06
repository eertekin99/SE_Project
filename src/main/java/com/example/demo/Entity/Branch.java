package com.example.demo.Entity;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

@Entity
@Table(name = "branch")
public class Branch {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "ID")
    long BID;
    @Column(name = "Location")
    String location;
    @Column(name = "Name")
    String name;
    @Column(name = "Mobile")
    long mobile;

//    @ManyToMany(fetch = FetchType.LAZY, cascade = CascadeType.PERSIST)
//    @JoinTable(name = "at",
//            joinColumns = {
//                    @JoinColumn(name = "Branch_ID", referencedColumnName = "ID",
//                            nullable = false, updatable = false)},
//            inverseJoinColumns = {
//                    @JoinColumn(name = "Cargo_ID", referencedColumnName = "ID",
//                            nullable = false, updatable = false)})
//    private Set<Cargo> cargos = new HashSet<>();

//    @OneToMany(mappedBy = "cargo")
//    private Set<Shipment> CargoBranch = new HashSet<Shipment>();

    @OneToMany(mappedBy = "shipmentBranch", cascade = CascadeType.ALL)
    private Set<Shipment> BranchCargo = new HashSet<Shipment>();

    @OneToMany(mappedBy = "employeeBranch")
    List<Employee> branchEmployees = new ArrayList<>();

    public List<Employee> getBranchEmployees() {
        return branchEmployees;
    }

    public void setBranchEmployees(List<Employee> branchEmployees) {
        this.branchEmployees = branchEmployees;
    }


    public void setBID(long BID) {
        this.BID = BID;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setMobile(long mobile) {
        this.mobile = mobile;
    }

    public void setBranchCargo(Set<Shipment> branchCargo) {
        BranchCargo = branchCargo;
    }

    public long getBID() {
        return BID;
    }

    public String getLocation() {
        return location;
    }

    public String getName() {
        return name;
    }

    public long getMobile() {
        return mobile;
    }

    public Set<Shipment> getBranchCargo() {
        return BranchCargo;
    }
}

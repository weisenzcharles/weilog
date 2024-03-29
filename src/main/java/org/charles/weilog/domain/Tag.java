package org.charles.weilog.domain;

import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.experimental.Accessors;

import javax.persistence.*;

@Data
@Accessors(chain = true)
@NoArgsConstructor
@Entity
@Table(name = "tags")
public class Tag {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;

    private String description;
    // 别名
    private String alias;
    // 分类 Id
    private Long taxonomyId;
    private String slug;

    private String color;

    private String type;

    private Integer sortIndex;

    private Boolean deleted;
}
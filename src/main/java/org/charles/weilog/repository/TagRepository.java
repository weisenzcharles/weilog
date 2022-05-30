package org.charles.weilog.repository;

import org.charles.weilog.domain.Term;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;

/**
 * 标签数据仓库。
 *
 * @author Charles
 */
public interface TagRepository extends JpaRepository<Term, Long>, JpaSpecificationExecutor<Term> {
}
